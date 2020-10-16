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
            string filename = @"C:\Users\Ferib\Documents\lab1-basicswitchconfig.pka";
            Console.WriteLine("Loading File: " + filename);
            Console.WriteLine("unpacking stage 1..");

            var data = unpackOne(File.ReadAllBytes(filename));

            Console.WriteLine(Encoding.ASCII.GetString(data));
            File.WriteAllText("test", Encoding.ASCII.GetString(data));

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static byte[] unpackOne(byte[] pkaBuffer)
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
                Console.Write(c.ToString("X2") + " ");
                result[i] = c;
            }
           
            return result;
        }
    }
}
