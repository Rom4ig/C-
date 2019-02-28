using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    public class GRIFileManager
    {
        public void GRI(string path)
        {
            string filepath;
            Directory.CreateDirectory(filepath = path + "\\GRIInspect");

            string filename;
            FileInfo fileInfo = new FileInfo(filename = filepath + "\\GRIdirinfo.txt");

            using (FileStream fstream = new FileStream(filename, FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fstream);
                if (Directory.Exists(path))
                {
                    sw.WriteLine("Files");
                    string[] files = Directory.GetFiles(path);
                    foreach (string s in files)
                    {
                        sw.WriteLine(s);
                    }
                    sw.WriteLine();
                    Console.WriteLine("Зайдите в папку: GRIInspect");
                    sw.WriteLine("Folders");
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (string s in dirs)
                    {
                        sw.WriteLine(s);
                    }
                }
                sw.Close();
            }

            Console.ReadKey();

            fileInfo.CopyTo("C:\\kek\\FileInfo.txt", true);
            fileInfo.Delete();

            string filecopydir;
            DirectoryInfo dInfo = new DirectoryInfo(filecopydir = path + "GRINew");
            dInfo.Create();

            string[] files2 = Directory.GetFiles(path);

            foreach (string s in files2)
            {
                File.Copy(s, filecopydir + "\\" + new FileInfo(s).Name);
            }
        }
    }
}