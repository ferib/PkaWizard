using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System.Runtime.InteropServices;
using PkaWizardLib.Pka;
using Nancy;
using Nancy.Hosting.Self;
using System.Threading;
using System.Security.Cryptography;
using ManyMonkeys.Cryptography;

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
            Console.WriteLine("Pka/Pkt Decoder for Packet Tracer v7\n");
            var host = new NancyHost(new Uri("http://localhost:5100"));

            Console.WriteLine("Starting server localhost:5100");
            host.Start();

            Console.WriteLine("Server started!");
            Thread.Sleep(-1);

            test();
           
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
            //byte[] buffer = new byte[] { 0x0A, 0x24, 0xBD, 0xA2, 0x60, 0x00, 0x8D, 0x0C, 0x32, 0xDF, 0x1C, 0x57, 0x04, 0x49, 0x65, 0xAE, 0xD1, 0xE1, 0x7B, 0xDE, 0x43, 0xA1, 0xF6, 0x8B, 0x7A, 0xB3, 0xF7, 0x31, 0xA6, 0xB6, 0xC3, 0x25, 0x41, 0x9C, 0xD6, 0xBE, 0x9C, 0x14, 0xE0, 0x78, 0xE2, 0xBD, 0x47, 0x57, 0x88, 0xC3, 0x18, 0xF8, 0x1D, 0x96, 0x56, 0x8A, 0x52, 0xB1, 0x01, 0x72, 0xF2, 0xB7, 0x13, 0x3C, 0x7A, 0x37, 0xA2, 0xBC, 0xA6, 0x3E, 0x6A, 0xFB, 0x57, 0xBD, 0x9B, 0x5D };

            //Twofish twofish = new Twofish()
            //{
            //    Mode = System.Security.Cryptography.CipherMode.CBC,
            //    Key = new byte[] { 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89, 0x89 },
            //    IV = new byte[] { 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10 }
            //};

            //ICryptoTransform decrypt = twofish.CreateDecryptor();
            //System.IO.MemoryStream msD = new System.IO.MemoryStream();
            //CryptoStream cryptostreamDecr = new CryptoStream(msD, decrypt, CryptoStreamMode.Write);

            //cryptostreamDecr.Write(buffer, 0, buffer.Length);
            //cryptostreamDecr.Close();

            //byte[] buffer_result = msD.GetBuffer();

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
