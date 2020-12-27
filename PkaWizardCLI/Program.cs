using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using PkaWizardLib.Patcher;
using PkaWizardLib.Repacker;

namespace PkaWizardCli
{
    class Program
    {
        static void Main(string[] args)
        {
            PkaWizardLib.Pka.PkaFile file = new PkaWizardLib.Pka.PkaFile(@"C:\Users\Ferib\Downloads\lab1-basicswitchconfig.pka");
            //file.Buffer = new byte[] { 0x0A, 0x24, 0xBD, 0xA2, 0x60, 0x00, 0x8D, 0x0C, 0x32, 0xDF, 0x1C, 0x57, 0x04, 0x49, 0x65, 0xAE, 0xD1, 0xE1, 0x7B, 0xDE, 0x43, 0xA1, 0xF6, 0x8B, 0x7A, 0xB3, 0xF7, 0x31, 0xA6, 0xB6, 0xC3, 0x25, 0x41, 0x9C, 0xD6, 0xBE, 0x9C, 0x14, 0xE0, 0x78, 0xE2, 0xBD, 0x47, 0x57, 0x88, 0xC3, 0x18, 0xF8, 0x1D, 0x96, 0x56, 0x8A, 0x52, 0xB1, 0x01, 0x72, 0xF2, 0xB7, 0x13, 0x3C, 0x7A, 0x37, 0xA2, 0xBC, 0xA6, 0x3E, 0x6A, 0xFB, 0x57, 0xBD, 0x9B, 0x5D };
            file.unpackStageOne();
            file.unpackStageTwo();
            //byte[] buff = new byte[] { 0xE1, 0xD2, 0x4E, 0xAE, 0xA5, 0x40, 0x37, 0x67, 0xB0, 0xAB, 0x35, 0x1C, 0x67, 0xFC, 0x29, 0x6F, 0xAE, 0xD5, 0x78, 0x91, 0x71, 0xD7, 0x30, 0xD6, 0xD6, 0x44, 0xA1, 0x96, 0xAA, 0x52, 0xE0, 0x46, 0xE5, 0x80, 0xA7, 0xF7, 0x1D, 0x3D, 0x52, 0x24, 0xA2, 0x3C, 0xA7, 0xD4, 0x85, 0x17, 0xF2, 0xFE, 0x6F, 0xC1, 0x51, 0x55, 0x00, 0x3E, 0xEB, 0xE2, 0x89, 0xEE, 0x7C, 0x0D, 0x78, 0x7A, 0x49, 0x97, 0x95, 0x6A, 0x55, 0x04, 0xAE, 0x2F, 0xA9, 0x29 };

            //for (int i = 0; i < buff.Length; i++)
            //    file.Buffer[i] = buff[i];
            
            //file.Buffer = new byte[] { 0x74, 0x6c, 0xbf, 0x30, 0xb5, 0x4b, 0x51, 0xf8, 0x6d, 0x88, 0x4c, 0xde, 0x2c, 0x1f, 0x04, 0xc0,
            //                           0x84, 0xd0, 0x4b, 0x3f, 0xf6, 0xd2, 0x40, 0xf5, 0x9c, 0x03, 0xaf, 0x24, 0xb3, 0x0d, 0xa1, 0x03,
            //                           0x5d, 0xd0, 0x12, 0xa5, 0x35, 0xd9, 0x1e, 0xc1, 0x11, 0x52, 0xe0, 0x41, 0xa9, 0xa2, 0x20, 0xb1,
            //                           0x24, 0x5c, 0x89, 0x9f, 0xf7, 0x70, 0x7b, 0xc7, 0x3a, 0xa1, 0x54, 0x99, 0xb4, 0x02, 0xd9, 0x86,
            //                           0x1c, 0x0c, 0x8a, 0x95, 0x8d, 0x3d, 0x2e, 0x7f, 0x27, 0xc2, 0x2c, 0xdb, 0x9e, 0xce, 0x0c, 0xc0 };
            file.unpackStageThree();
            file.unpackStageFour();

            string RepackDir = "";
            string OutputPath = "";
            string PacketTracerPath = "";
            byte XorKey = 0x00;

            for (int i = 0; i < args.Length; i++)
            {
                // Patching
                if(args[0].ToLower() == "patch")
                {
                    if (i == 1)
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
                    if (i == 1)
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
                            PacketTracerRepacker repackRestore = new PacketTracerRepacker(RepackDir);
                            repackRestore.RestoreFiles();
                            RepackDir = "N/A"; // prevent repack lateron
                            break;
                        case "-t":
                            if (args.Length > i + 1)
                            {
                                PacketTracerRepacker repack = new PacketTracerRepacker(null);
                                byte[] newfile = repack.Repack(args[i + 1], XorKey);
                                if(!File.Exists(args[i + 1] + ".bak"))
                                    File.Copy(args[i + 1], args[i + 1] + ".bak");
                                File.WriteAllBytes(args[i + 1], newfile);
                            }
                            break;
                        default:
                            break;
                    }
                }
                
                //Console.WriteLine($"[{i}] {args[i]}");
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
            else if (RepackDir != "" && RepackDir != "N/A")
            {
                PacketTracerRepacker repacker = new PacketTracerRepacker(RepackDir);
                if (repacker.RepackDirectory(XorKey))
                    Console.WriteLine("Repacking complete!");
                else
                    Console.WriteLine("Repacking failed!");
            }
            else if(RepackDir != "N/A")
                Help();

#if DEBUG
            Console.ReadKey(); // handy to keep it open in VS
#endif
        }

        static void Help()
        {
            string HelpContent =    "PkaWizardCLI Usage: [patch | repack] [file | dir] [-h] [-r] [-k] [-k -t] [-o] \n\r" +
                                    "\n\r" +
                                    "DIY Security tool for Packet Tracer\n\r" +
                                    "\n\r" +
                                    "Positional arguments:\n\r" +
                                    "\tpatch\tPatching Packet Tracer\n\r" +
                                    "\trepack\tRepacking files\n\r" +
                                    "\n\r" +
                                    "\tfile\tPacket Tracer binary file path (patch only)\n\r" +
                                    "\tdir\tDirectory to scan for .pks, .pkd, .pka and repack (repack only)\n\r" +
                                    "\n\r" +
                                    "Optional arguments: \n\r" +
                                    "\t-t\tTarget specific file\n\r" +
                                    "\t-h\tShows this help message\n\r" +
                                    "\t-k\tXOR key (stage 1)\n\r" +
                                    "\t-o\tOutput File (patch only)\n\r" +
                                    "\t-r\tRestore patch/repack (unfinished)\n\r" +
                                    "\n\r";

            Console.WriteLine(HelpContent);
        }
    }
}
