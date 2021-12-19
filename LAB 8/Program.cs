using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_8
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo d in drives)
            {
                Console.WriteLine("Название: {0}", d.Name);
                if(d.IsReady)
                {
                    Console.WriteLine("Объем диска:{0}", d.TotalSize);
                    Console.WriteLine("Свободно:{0}", d.AvailableFreeSpace);
                }
                Console.WriteLine();

            }
            Console.ReadKey();



        }
    }
}
