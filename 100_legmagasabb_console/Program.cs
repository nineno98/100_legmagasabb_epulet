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
            feladat01();
            feladat02();
            feladat03();
            feladat04();
            

            Console.ReadKey();
        }

        private static void feladat04()
        {
            int evszam = evszambekeres();
            Console.WriteLine("Az évszám előtt épült épületek magassága:\n\t"+epuletek.Where(x => x.Epitesi_ev_ < evszam).Sum(y => y.Magassag_));
        }

        private static int evszambekeres()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Add meg az évszámot:");
                    int result = int.Parse(Console.ReadLine());
                    return result;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Egész számot adj meg!");
                }
            }
        }

        private static void feladat03()
        {
            Console.WriteLine("3. Feladat");
        }

        private static void feladat02()
        {

            Console.WriteLine("2. feladat: " + epuletek.Where(x => !x.Nev_.Contains("Tower")).Count());
            /*int counter = 0;
            foreach (var item in epuletek)
            {
                if (!item.Nev_.Contains("Tower"))
                {
                    counter++;
                }
            }
            Console.WriteLine("2. feladat: "+counter);*/
        }

        private static void feladat01()
        {
            Console.WriteLine("1. Feladat: Épületek száma: "+epuletek.Count);
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
