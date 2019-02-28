using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;


namespace Lab13
{
    public class GRIDiskInfo
    {
        public void DiskInfo()
        {
            Console.WriteLine("DiskInfo");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("\tИмя: {0}", drive.Name);
                Console.WriteLine("\tТип: {0}", drive.DriveType);

                if (drive.IsReady)
                {
                    Console.WriteLine("\tФормат: {0}", drive.DriveFormat);
                    Console.WriteLine("\tОбъём: свободно - {0} GB, доступно - {1} GB", drive.AvailableFreeSpace / 1024 / 1024 / 1024, drive.TotalFreeSpace / 1024 / 1024 / 1024);
                    Console.WriteLine("\tОбщий объём: {0} GB", drive.TotalSize/1024/1024/1024);
                }
                Console.WriteLine();
            }
        }
    }
}
