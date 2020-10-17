using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace PkaWizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("unpacking to stage 1..");
            var data1 = unpackStageOne(File.ReadAllBytes("stage0.mem"));
            Console.WriteLine("\n");

            Console.WriteLine("unpacking to stage 3..");
            var data3 = unpackStageThree(File.ReadAllBytes("stage2.mem"));
            Console.WriteLine("\n");

            Console.WriteLine("unpacking to stage 4..");
            var data4 = unpackStageFour(data3);
            Console.WriteLine("\n");

            //Console.WriteLine(Encoding.ASCII.GetString(data));
            //File.WriteAllText("test", Encoding.ASCII.GetString(data));
            File.WriteAllBytes("stage1.out", data1);
            File.WriteAllBytes("stage3.out", data3);
            File.WriteAllBytes("stage4.xml", data4);

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static byte[] unpackStageOne(byte[] pkaBuffer)
        {
            // cant fucking believe t his worked first try lolol
            byte[] result = new byte[pkaBuffer.Length];
            byte k = (byte)pkaBuffer.Length;
            int s = pkaBuffer.Length;
            for(int i = 0; i < pkaBuffer.Length; i++)
            {
                byte ch = pkaBuffer[pkaBuffer.Length - i - 1];
                byte a = (byte)(k * (byte)i);
                byte c = (byte)(pkaBuffer.Length - a);
                c ^= ch;
                if (i < 20)
                    Console.Write(c.ToString("X2") + " ");
                else if (i == 20)
                    Console.WriteLine();
                else if (i > pkaBuffer.Length - 20)
                    Console.Write(c.ToString("X2") + " ");
                result[i] = c;
            }
           
            return result;
        }

        private static byte[] unpackStageThree(byte[] pkaBuffer2)
        {
            byte[] result = new byte[pkaBuffer2.Length];
            for (int i = 0; i < pkaBuffer2.Length; i++)
            {
                byte ch = pkaBuffer2[i];
                byte key = (byte)(pkaBuffer2.Length - i);
                ch ^= key;
                if (i < 20)
                    Console.Write(ch.ToString("X2") + " ");
                else if (i == 20)
                    Console.WriteLine();
                else if (i > pkaBuffer2.Length - 20)
                    Console.Write(ch.ToString("X2") + " ");
                result[i] = ch;
            }
            return result;
        }

        private static byte[] unpackStageFour(byte[] pkaBuffer3)
        {
            byte[] xmlResult = new byte[(pkaBuffer3[0] * 0x1000000) + (pkaBuffer3[1] * 0x10000) + (pkaBuffer3[2] * 0x100) + (pkaBuffer3[3] * 0x1)]; // first 4 bytes are size
            var zlibdata = pkaBuffer3.ToList();
            zlibdata.RemoveRange(0, 4);

            //InflaterInputBuffer inflate = new InflaterInputBuffer(new MemoryStream(zlibdata.ToArray()));
            InflaterInputStream inflate = new InflaterInputStream(new MemoryStream(zlibdata.ToArray()));
            inflate.Read(xmlResult, 0, xmlResult.Length);

            return xmlResult;
        }
    }
}
