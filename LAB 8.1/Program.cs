using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName= (@"D:\объекты");
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

            }





            DirectoryInfo d = new DirectoryInfo(@"D:\объекты");
            Console.WriteLine("Список каталогов");
            foreach (var item in d.GetDirectories())
                {
                Console.WriteLine(item.Name);
                Console.WriteLine("список подкаталогов");
                foreach (var it in item.GetDirectories())
                    Console.WriteLine(item.Name);
                Console.WriteLine();
                }
            
            
            Console.ReadLine();
            Console.ReadKey();



        }
    }
}
