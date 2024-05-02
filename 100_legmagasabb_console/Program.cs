using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _100_legmagasabb_console
{
    class Program
    {
        private static List<Epulet> epuletek = new List<Epulet>();
        static void Main(string[] args)
        {
            
            beolvasas();
           
            foreach (var item in epuletek)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void beolvasas()
        {
            using (StreamReader sr = new StreamReader("100_tallest_javitott2.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Replace('.', ',').Split(';');
                    Epulet ep = new Epulet(int.Parse(line[0]), line[1], line[2], double.Parse(line[3]), double.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6]));
                    epuletek.Add(ep);

                }
            }
        }
    }
}
