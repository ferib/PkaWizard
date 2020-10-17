using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

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

            //Console.WriteLine(Encoding.ASCII.GetString(data));
            //File.WriteAllText("test", Encoding.ASCII.GetString(data));
            File.WriteAllBytes("stage1.out", data1);
            File.WriteAllBytes("stage3.out", data1);

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

            // write .zlib
            var dotzlib = result.ToList();
            dotzlib.RemoveRange(0, 4);
            File.WriteAllBytes("stage3.zlib",dotzlib.ToArray());
            return result;
        }
    }
}
