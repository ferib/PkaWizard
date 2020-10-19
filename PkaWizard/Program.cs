using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System.Runtime.InteropServices;

namespace PkaWizard
{
   
    static class Program
    {
        //[DllImport("cryptopp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //public static extern IntPtr RSAEncryptString(string filename, string seed, string message);


        //[DllImport("cryptopp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "StringSource")]
        //public static extern void StringSource(byte[] buffer, int size, bool pumpAll);

        static void Main(string[] args)
        {
            test();
            Console.WriteLine("Pka/Pkt Decoder for Packet Tracer v7\n");

            Console.WriteLine("unpacking to stage 1..");
            var data1 = unpackStageOne(File.ReadAllBytes("stage0.mem"));
            Console.WriteLine("\n");

            Console.WriteLine("unpacking to stage 2..");
            var data2 = unpackStageTwo(File.ReadAllBytes("stage1.out"));
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

        private static void test()
        {
            PkaFile pka = new PkaFile("stage2.mem");
            
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
                result[i] = c;
#if DEBUG
                if (i < 20)
                    Console.Write(c.ToString("X2") + " ");
                else if (i == 20)
                    Console.WriteLine();
                else if (i >= pkaBuffer.Length - 20)
                    Console.Write(c.ToString("X2") + " ");
#endif
            }
           
            return result;
        }

        private static byte[] unpackStageTwo(byte[] pkaBuffer1)
        {
            //StringSource(pkaBuffer1, pkaBuffer1.Length, true);
            Console.WriteLine("Figure out how to PumpAll and re-created in C#");

            
            return null;
        }

        private static byte[] unpackStageThree(byte[] pkaBuffer2)
        {
            byte[] result = new byte[pkaBuffer2.Length];
            for (int i = 0; i < pkaBuffer2.Length; i++)
            {
                byte ch = pkaBuffer2[i];
                byte key = (byte)(pkaBuffer2.Length - i);
                ch ^= key;
                result[i] = ch;
#if DEBUG
                if (i < 20)
                    Console.Write(ch.ToString("X2") + " ");
                else if (i == 20)
                    Console.WriteLine();
                else if (i >= pkaBuffer2.Length - 20)
                    Console.Write(ch.ToString("X2") + " ");
#endif
            }
            return result;
        }

        private static byte[] unpackStageFour(byte[] pkaBuffer3)
        {
            byte[] xmlResult = new byte[(pkaBuffer3[0] * 0x1000000) + (pkaBuffer3[1] * 0x10000) + (pkaBuffer3[2] * 0x100) + (pkaBuffer3[3] * 0x1)]; // first 4 bytes are size
            var zlibdata = pkaBuffer3.ToList();
            zlibdata.RemoveRange(0, 4);

            InflaterInputStream inflate = new InflaterInputStream(new MemoryStream(zlibdata.ToArray()));
            inflate.Read(xmlResult, 0, xmlResult.Length);

#if DEBUG
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Encoding.UTF8.GetString(xmlResult.ToList().GetRange(0, 420).ToArray()));
            Console.ForegroundColor = ConsoleColor.Gray;
#endif

            return xmlResult;
        }
    }
}
