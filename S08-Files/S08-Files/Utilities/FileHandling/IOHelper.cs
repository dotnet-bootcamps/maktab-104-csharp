using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S08_Files.Utilities.FileHandling
{
    internal class IOHelper
    {

        public void ShowListOfDrives()
        {
            var drives=DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine($"Name : {drive.Name}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"DriveType     : {drive.DriveType}");
                Console.WriteLine($"IsReady       : {drive.IsReady}");


                Console.WriteLine($"---VolumeLabel        : {drive.VolumeLabel}");
                Console.WriteLine($"---DriveFormat        : {drive.DriveFormat}");
                Console.WriteLine($"---AvailableFreeSpace : {drive.AvailableFreeSpace}");
                Console.WriteLine($"---TotalFreeSpace     : {drive.TotalFreeSpace}");
                Console.WriteLine($"---TotalSize          : {drive.TotalSize}");

                Console.WriteLine("\n\n");
            }
        }


        public void GetDriveInfo(string driveName)
        {
            var driveInfo = new DriveInfo(driveName);
            
            Console.WriteLine($"Name : {driveInfo.Name}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"DriveType     : {driveInfo.DriveType}");
            Console.WriteLine($"IsReady       : {driveInfo.IsReady}");


            Console.WriteLine($"---VolumeLabel        : {driveInfo.VolumeLabel}");
            Console.WriteLine($"---DriveFormat        : {driveInfo.DriveFormat}");
            Console.WriteLine($"---AvailableFreeSpace : {driveInfo.AvailableFreeSpace}");
            Console.WriteLine($"---TotalFreeSpace     : {driveInfo.TotalFreeSpace}");
            Console.WriteLine($"---TotalSize          : {driveInfo.TotalSize}");

            Console.WriteLine("\n\n");
        }


    }
}
