using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    public class GRILog
    {
        public void Search()
        {
            string curTimeLong = DateTime.Now.ToLongTimeString();
            using (StreamWriter sw = new StreamWriter(@"I:\\kek\\log.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine("File created time : " + curTimeLong);
                DriveInfo[] drives = DriveInfo.GetDrives();
                string[] files = Directory.GetFiles("C:\\kek");
                foreach (string f in files)
                {
                    sw.WriteLine(f);
                }
                sw.Close();
                StreamReader sr = new StreamReader(@"I:\\kek\\log.txt");
                string[] infos = sr.ReadToEnd().Split('\n');
                sr.Close();
                StreamWriter sx = new StreamWriter(@"I:\\kek\\log.txt", true, System.Text.Encoding.Default);
                sx.WriteLine("Всего записей: " + (infos.Length+1));
                FileInfo finf = new FileInfo("C:\\kek\\FileInfo.txt");
                if (finf.Exists)
                {
                    int h = finf.CreationTime.Hour;
                    if (h > 11)
                        finf.Delete();
                    Console.WriteLine("Complete");
                }
                sx.WriteLine(finf.Name);
                sx.Close();
            }
        }
    }
}