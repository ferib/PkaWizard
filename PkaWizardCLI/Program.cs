using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PkaWizardCli;
using PkaWizardCli.Pka;
using PkaWizardCli.Patcher;
using PkaWizardCli.Repacker;

namespace PkaWizardCli
{
    class Program
    {
        static void Main(string[] args)
        {

            PacketTracerRepacker repacker = new PacketTracerRepacker("N:\\Cisco Packet Tracer 7.2.1");
            repacker.RepackDirectory(0x42);

            string RepackDir = "";
            string OutputPath = "";
            string PacketTracerPath = "";
            byte XorKey = 0x00;

            for (int i = 0; i < args.Length; i++)
            {
                // Patching
                if(args[0].ToLower() == "patch")
                {
                    if (i == 0)
                        PacketTracerPath = args[i];

                    switch (args[i])
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
                        case "-r":
                            Console.WriteLine("Error, Restore not yet added");
                            break;
                        default:
                            break;
                    }
                }
                else if(args[0].ToLower() == "repack")
                {
                    if (i == 0)
                        RepackDir = args[i];

                    switch (args[i])
                    {
                        case "-k":
                            if (args.Length > i + 1)
                                if (!byte.TryParse(args[i + 1], out XorKey))
                                    Console.WriteLine("Error, invalid XOR key.");
                            break;
                        case "-h":
                            Help();
                            break;
                        case "-r":
                            Console.WriteLine("Error, Restore not yet added");
                            break;
                        default:
                            break;
                    }
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
            else if (RepackDir != "")
            {

            }
            else
                Help();

            Console.ReadKey();
        }

        static void Help()
        {
            string HelpContent =    "PkaWizardCli Usage: [patch | repack] [file | dir] [-h] [-r] [-k] [-o] \n\r" +
                                    "\n\r" +
                                    "Patches PacketTracer unpacking algorithm\n\r" +
                                    "\n\r" +
                                    "Positional arguments:\n\r" +
                                    "\tpatch\tPatching Packet Tracer\n\r" +
                                    "\trepack\tRepacking files\n\r" +
                                    "\n\r" +
                                    "\tfile\tPacket Tracer binary file path (patch only)\n\r" +
                                    "\tdir\tDirectory to scan for .pks, .pkd and repack (repack only)\n\r" +
                                    "\n\r" +
                                    "Optional arguments: \n\r" +
                                    "\t-h\tShows this help message\n\r" +
                                    "\t-k\tXOR key (stage 1)\n\r" +
                                    "\t-o\tOutput File (patch only)\n\r" +
                                    "\t-r\tRestore patch/repack (unfinished)\n\r" +
                                    "\n\r";

            Console.WriteLine(HelpContent);
        }
    }
}
