using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GRIDiskInfo diskInfo = new GRIDiskInfo();
                diskInfo.DiskInfo();

                GRIFileInfo file = new GRIFileInfo();
                file.FileData("C:\\KP\\in.txt");

                GRIDirInfo dirInfo = new GRIDirInfo();
                dirInfo.DirInfo("C:\\KP");

                GRIFileManager fileManager = new GRIFileManager();
                fileManager.GRI("C:");

                Archive ar = new Archive();
                ar.GetArchive("C:\\ForArchive");

                Console.WriteLine("Folders GRI, GRIFiles will be deleted");
                if (Console.ReadKey().KeyChar == 'g')
                {
                    Directory.Delete("C:\\GRIInspect", true);
                    Directory.Delete("C:\\GRIFiles", true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message +"\n"+ex.StackTrace);
            }
            finally
            {
                GRILog log = new GRILog();
                log.Search();
                Console.WriteLine("Success");
            }
        }
    }
}
