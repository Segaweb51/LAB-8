using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LAB_8._2
{

    class Program
    {
        static void Main(string[] args)
        {





            string path = "Logs2/log.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter sw = new StreamWriter(path, true));
            {

                int[] array = new int[10];
                Random random = new Random();
                int S = 0;

                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    S += array[i];
                    Console.Write("{0}", array[i]);
                }
                Console.WriteLine();
                Console.WriteLine(S);



            }

            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            
            Console.ReadKey();
















        }
    }
}