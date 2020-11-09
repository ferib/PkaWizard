using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PkaWizardCli.Pka;

namespace PkaWizardCli.Repacker
{
    class PacketTracerRepacker
    {
        private string ScanDirectory;
        private bool MakeBackup = true;
        private List<string> Directorys;

        public PacketTracerRepacker(string path)
        {
            if(Directory.Exists(path))
                this.ScanDirectory = path;
            this.Directorys = new List<string>();
        }

        public bool RestoreFiles()
        {
            string[] fileExtension = { ".bak" };
            List<string> files = new List<string>();

            // collect files
            GetDirectorys(this.ScanDirectory);
            foreach (var d in this.Directorys)
            {
                // check if file contains fileExtension
                foreach (var f in Directory.GetFiles(d))
                    foreach (var ext in fileExtension)
                        if (f.Substring(f.Length - ext.Length, ext.Length) == ext)
                        {
                            files.Add(f);
                            break;
                        }
            }

            foreach(var file in files)
            {
                try
                {

                    string origFilename = file.Substring(0, file.Length - 4);
                    if (File.Exists(origFilename))
                        File.Delete(origFilename);
                    Console.WriteLine($"Restoring file: {file}");
                    File.Copy(file, origFilename);
                }
                catch(Exception e)
                {
                    var oldColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Failed restoring: {file}\n\r{e.Message}");
                    Console.ForegroundColor = oldColor;
                }
            }

            return true;
        }

        public bool RepackDirectory(byte xorKey)
        {
            string[] fileExtension = { ".pka", ".pts", ".ptd" };
            List<string> files = new List<string>();

            // collect files
            GetDirectorys(this.ScanDirectory);
            foreach(var d in this.Directorys)
            {
                // check if file contains fileExtension
                foreach (var f in Directory.GetFiles(d))
                    foreach(var ext in fileExtension)
                        if(f.Substring(f.Length-ext.Length, ext.Length) == ext)
                        {
                            files.Add(f);
                            break;
                        } 
            }

            // re-pack files
            foreach(var file in files)
            {
                try
                {
                    // backup, but only if .bak of file not exists, or we may corrupt original backup files
                    if (this.MakeBackup && (!File.Exists(file + ".bak")))
                    File.Copy(file, file + ".bak");

                    byte[] newFile = Repack(file, xorKey);
                    File.WriteAllBytes(file, newFile);
                }
                catch (Exception e)
                {
                    var oldColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Failed re-packing: {file}\n\r{e.Message}");
                    Console.ForegroundColor = oldColor;
                }
            }

            return true;
        }

        public byte[] Repack(string file, byte xorKey)
        {
            // unpack stage 1
            Console.WriteLine($"Re-packing file: {file} (key: {xorKey})");
            PkaFile pkaFile = new PkaFile(file);
            pkaFile.unpackStageOne();

            for (int i = 0; i < pkaFile.Buffer.Length ; i++)
            {
                pkaFile.Buffer[i] ^= xorKey;
            }
            pkaFile.Buffer = pkaFile.Buffer.Reverse().ToArray(); // reverse ;D

            return pkaFile.Buffer;
        }

        private void GetDirectorys(string path)
        {
            var dirs = Directory.GetDirectories(path);
                this.Directorys.AddRange(dirs);
                foreach (var d in dirs)
                    GetDirectorys(d);
        }
    }
}
