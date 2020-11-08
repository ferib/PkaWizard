using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PkaWizard.Pka;
using System.Xml.Serialization;

namespace PkaWizard.Pka
{
    /*
         Content
	        - ACTIVITY
		        - INSTRUCTIONS
			        - PAGE(contains instructions HTML)

	        - PASS (hashed password)
	
	        - AUTHOR (small note + disclaimer about author)
	
	        - OPTIONS (lots of useless data)
	
	        - vERSIONField (pka file version info)

        NOTE: Since we cannot deserialise a prefect objects, 
              its not safe to serialize it and expect it to 
              work in Packet Tracer, therefore we will only
              read the content, create a filter, and replace
              the original text with the new text.

     */
    class PkaFile
    {
        public string Filename { get; private set; }
        private byte[] Buffer { get; set; }
        private byte[] XmlContent { get; set; }
        public PACKETTRACER5_ACTIVITY Content { get; set; }
        private XmlSerializer xmlSerializer { get; set; }

        public PkaFile(string filename)
        {
            this.Filename = filename;
            if (File.Exists(filename))
                this.Buffer = File.ReadAllBytes(filename);
            else
                throw new Exception("File not exist");

            Unpack();
        }

        private void Unpack()
        {
            // TODO: fix stage two!!

            //if (unpackStageOne())
            //    if (unpackStageTwo())
                    if (unpackStageThree())
                        if (unpackStageFour())
                            Console.WriteLine("Unpacking done!");
        }

        private bool unpackStageOne()
        {
            // cant fucking believe t his worked first try lolol
            byte k = (byte)this.Buffer.Length;
            int s = this.Buffer.Length;
            for (int i = 0; i < this.Buffer.Length; i++)
            {
                byte ch = this.Buffer[this.Buffer.Length - i - 1];
                byte a = (byte)(k * (byte)i);
                byte c = (byte)(this.Buffer.Length - a);
                c ^= ch;
                this.Buffer[i] = c;
#if DEBUG
                if (i < 20)
                    Console.Write(c.ToString("X2") + " ");
                else if (i == 20)
                    Console.WriteLine();
                else if (i >= this.Buffer.Length - 20)
                    Console.Write(c.ToString("X2") + " ");
#endif
            }
            return true;
        }

        private bool unpackStageTwo()
        {
            //StringSource(pkaBuffer1, pkaBuffer1.Length, true);
            Console.WriteLine("Figure out how to PumpAll and re-created in C#");
            return true;
        }

        private bool unpackStageThree()
        {
            for (int i = 0; i < this.Buffer.Length; i++)
            {
                byte ch = this.Buffer[i];
                byte key = (byte)(this.Buffer.Length - i);
                ch ^= key;
                this.Buffer[i] = ch;
#if DEBUG
                if (i < 20)
                    Console.Write(ch.ToString("X2") + " ");
                else if (i == 20)
                    Console.WriteLine();
                else if (i >= this.Buffer.Length - 20)
                    Console.Write(ch.ToString("X2") + " ");
#endif
            }
            return true;
        }

        private bool unpackStageFour()
        {
            this.XmlContent = new byte[(this.Buffer[0] * 0x1000000) + (this.Buffer[1] * 0x10000) + (this.Buffer[2] * 0x100) + (this.Buffer[3] * 0x1)]; // first 4 bytes are size
            var zlibdata = this.Buffer.ToList();
            zlibdata.RemoveRange(0, 4);

            // check for zlib 'Default Compression (no preset dictionary)'
            if (zlibdata[0] != 0x78 && zlibdata[1] != 0x9C) 
                return false; // invalid header - https://en.wikipedia.org/wiki/List_of_file_signatures

            InflaterInputStream inflate = new InflaterInputStream(new MemoryStream(zlibdata.ToArray()));
            inflate.Read(this.XmlContent, 0, this.XmlContent.Length);

#if DEBUG
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Encoding.UTF8.GetString(this.XmlContent.ToList().GetRange(0, 420).ToArray()));
            Console.ForegroundColor = ConsoleColor.Gray;
            File.WriteAllBytes("test.xml", this.XmlContent);
#endif

            // patch invalid character 0x03
            for (int i = 0; i < this.XmlContent.Length; i++)
                if (this.XmlContent[i] < 0x09)
                    this.XmlContent[i] = 0x3F; // ASCII questionmark

            this.xmlSerializer = new XmlSerializer(typeof(PACKETTRACER5_ACTIVITY));
            this.Content = (PACKETTRACER5_ACTIVITY)this.xmlSerializer.Deserialize(new MemoryStream(this.XmlContent));
            return true;
        }
    }
}
