using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    public class Archive
    {
        public void GetArchive(string path)
        {
            if(File.Exists("C:\\kek\\Archive.7z"))
            File.Delete("C:\\kek\\Archive.7z");
            ZipFile.CreateFromDirectory(path, "C:\\kek\\Archive.7z");
            Directory.Delete("C:\\ForArchiveEx", true);
            Directory.CreateDirectory("C:\\ForArchiveEx");
            using (ZipArchive archive = ZipFile.OpenRead("C:\\kek\\Archive.7z"))
            {
                foreach (ZipArchiveEntry file in archive.Entries)
                {
                    ZipFile.ExtractToDirectory("C:\\kek\\Archive.7z", "C:\\ForArchiveEx");
                    break;
                }
            }

        }
    }
}