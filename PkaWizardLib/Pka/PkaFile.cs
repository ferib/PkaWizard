﻿using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PkaWizardLib.Pka;
using System.Xml.Serialization;
using System.Security.Cryptography;
using ManyMonkeys.Cryptography;

namespace PkaWizardLib.Pka
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
    public class PkaFile
    {
        public string Filename { get; private set; }
        public byte[] Buffer { get; set; }
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

            //Unpack();
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

        public bool unpackStageOne()
        {
            byte k = (byte)this.Buffer.Length;
            int s = this.Buffer.Length;
            byte[] result = new byte[this.Buffer.Length];

            for (int i = 0; i < this.Buffer.Length; i++)
            { 
                byte ch = this.Buffer[this.Buffer.Length - i - 1];
                byte a = (byte)(k * (byte)i);
                byte c = (byte)(this.Buffer.Length - a);
                c ^= ch;
                result[i] = c;
#if DEBUG
                if (i < 20)
                    Console.Write(c.ToString("X2") + " ");
                else if (i == 20)
                    Console.WriteLine();
                else if (i >= this.Buffer.Length - 20)
                    Console.Write(c.ToString("X2") + " ");
#endif
            }
            this.Buffer = result;

            return true;
        }

        public bool unpackStageTwo()
        {
            Twofish twofish = new Twofish()
            {
                Mode = System.Security.Cryptography.CipherMode.CBC,
                Key = new byte[] { 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89 },
                IV = new byte[] { 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10 }
            };

            ICryptoTransform decrypt = twofish.CreateDecryptor();
            System.IO.MemoryStream msD = new System.IO.MemoryStream();
            CryptoStream cryptostreamDecr = new CryptoStream(msD, decrypt, CryptoStreamMode.Write);

            cryptostreamDecr.Write(this.Buffer, 0, this.Buffer.Length);
            cryptostreamDecr.Close();

            byte[] tmp = msD.GetBuffer();
            Console.WriteLine(tmp.Length);
            for (int i = 0; i < this.Buffer.Length; i++)
                this.Buffer[i] = tmp[i];

            return true;
        }

        public bool unpackStageThree()
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

        public bool unpackStageFour()
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
