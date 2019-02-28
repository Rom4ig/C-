using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    public class MIAFiles
    {
        public void GetArchive(string path)
        {
            ZipFile.CreateFromDirectory(path, "D:\\Archive.gz");
        }
    }
}
