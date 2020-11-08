using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PkaWizardCli;
using PkaWizardCli.Pka;
using PkaWizardCli.Patcher;

namespace PkaWizardCli
{
    class Program
    {
        static void Main(string[] args)
        {
            string OutputPath = "";
            string PacketTracerPath = "";
            byte XorKey = 0x00;

            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0)
                    PacketTracerPath = args[i];

                switch(args[i])
                {
                    case "-k":
                        if (args.Length > i + 1)
                            if (!byte.TryParse(args[i + 1], out XorKey))
                                Console.WriteLine("Error, invalid XOR key.");
                        break;
                    case "-o":
                        if (args.Length > i + 1)
                            OutputPath = args[i + 1];
                        break;
                    case "-h":
                        Help();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"[{i}] {args[i]}");
            }

            if (args.Length == 0)
                Help();
            else if (PacketTracerPath != "")
            {
                PacketTracerPatcher patcher = new PacketTracerPatcher(PacketTracerPath)
                {
                    OutputPath = OutputPath
                };
                if (patcher.PatchDecoding(XorKey))
                    Console.WriteLine("Patching complete!");
                else
                    Console.WriteLine("Patching failed!");
            }
            else
                Help();

            Console.ReadKey();
        }

        static void Help()
        {
            string HelpContent =    "PkaWizardCli Usage: file [-h] [-k] [-o] \n\r" +
                                    "\n\r" +
                                    "Patches PacketTracer unpacking algorithm\n\r" +
                                    "\n\r" +
                                    "Positional arguments:\n\r" +
                                    "\tfile\tPacket Tracer binary file path\n\r" +
                                    "\n\r" +
                                    "Optional arguments: \n\r" +
                                    "\t-h\tShows this help message\n\r" +
                                    "\t-k\tNew XOR key (stage 1)\n\r" +
                                    "\t-o\tOutput File\n\r" +
                                    "\n\r";

            Console.WriteLine(HelpContent);
        }
    }
}
