using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PkaWizard.Patcher
{
    class PacketTracerPatcher
    {
        /*      The patcher is minimalistic and is based on my article: https://ferib.dev/blog.php?l=post/Protecting_Packet_Tracer_Myself_Because_No_One_Gives_a_Shit
                The goal was to point out how vulnerable the original Packet Tracer is, and my goal is to patch
                Packet Tracers .pka encoding algorithm, so we can force students to use our modified version
                
                For good practice, we should also implement security features to prevent debuggers, hooking, patching, etc.
                But for now, I will ONLY patch the .pka unpacking algorithm as PoC.
        */

        private string PacketTracerPath;
        public string OutputPath;
        private byte[] Content;

        public PacketTracerPatcher(string path)
        {
            if (File.Exists(path))
                this.PacketTracerPath = path;
            
        }

        public bool PatchDecoding(byte xorKey = 0x42)
        {
            // error handle
            if (this.PacketTracerPath == "" || !File.Exists(this.PacketTracerPath))
            {
                Console.WriteLine("Invalid file selected.");
                return false;
            }

            // read bytes
            this.Content = File.ReadAllBytes(this.PacketTracerPath);

            // search for pattern
            byte[] StageOnePatchLocation = { 0x0F, 0xBE, 0xC3, 0x41, 0x0F, 0xBE, 0xCF, 0x0F, 0xAF, 0xC8, 0x44, 0x2A, 0xF1, 0x45 };

            // TODO: Only scan the .text section to improve speed?
            int matchLocation = -1;
            for (int i = 0; i < this.Content.Length; i++)
            {
                // check if first and last byte of pattern match (optimal)
                if(StageOnePatchLocation[0] == this.Content[i] && StageOnePatchLocation[StageOnePatchLocation.Length-1] == this.Content[i+ StageOnePatchLocation.Length-1])
                {
                    // check if all other bytes in between match
                    matchLocation = i; // possible match
                    for (int j = 1; j <  StageOnePatchLocation.Length -2; j++)
                    {
                        if (StageOnePatchLocation[j] != this.Content[j + i])
                        {
                            matchLocation = -1; // no match
                            break;
                        }
                    }
                }
            }

            // error handle
            if (matchLocation == -1)
            {
                Console.WriteLine("Patch location not found :(");
                return false;
            }

            // patch location
            byte[] StageOnePatchXor = { 0x90, 0x6A, 0x00, 0x41, 0x5E, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            StageOnePatchXor[2] = xorKey; // set a hardcoded XOR key (old one is based on file length)

            // write patch to file
            string newFilename = this.OutputPath;
            if(newFilename == "")
                newFilename = this.PacketTracerPath.Split(".exe")[0] + "_patched.exe";

            File.WriteAllBytes(newFilename, this.Content);

            Console.WriteLine($"File patched at 0x{matchLocation.ToString("X16")}");
            Console.WriteLine($"File saved at {newFilename}");
            return true;
        }

    }
}
