using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                // backup
                if(this.MakeBackup)
                {
                    if(!File.Exists(file + ".bak"))
                    {
                        // only backup if .bak of file not exists, or we may corrupt original backup files
                    }
                }
            }

            return true;
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
