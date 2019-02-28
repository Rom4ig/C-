using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    public class GRIFileInfo
    {
        public void FileData(string path)
        {
            Console.WriteLine("FileInfo");
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("\tПолный путь : {0}", fileInf.DirectoryName);
                Console.WriteLine("\tИмя: {0}", fileInf.Name);
                Console.WriteLine("\tОбъём: {0} KB\n\tРасширение: {1}\n\tДата создания: {2}", fileInf.Length / 1024, fileInf.Extension, fileInf.CreationTime);
            }
            else
            {
                Console.WriteLine("This file doesn't exists");
            }
        }
    }
}
