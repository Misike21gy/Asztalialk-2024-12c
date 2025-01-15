using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szofteszt01._15
{
    class Program
    {
        struct Adat
        {
            public string nev;
            public int oraber;
            public string kolis;
            public string lakhely;
        }
        static void Main(string[] args)
        {
            static void Main(string[] args)
        {
                bool vanfile = File.Exists("nevek.txt");
                if (vanfile)
                {

                }
                   string[] kategoriak = File.ReadAllLines("nevek.txt");
                                   int i;
                

                for (i = 0; i < kategoriak.Length; i++)
                {
                    Console.WriteLine(kategoriak[i]);
                }

                Adat[] adatok = new Adat[kategoriak.Length];

                for (i = 0; i < kategoriak.Length; i++)
                {
                    string[] sorok = kategoriak[i].Split(' ');
                    adatok[i].nev = sorok[0];
                    adatok[i].oraber = int.Parse(sorok[1]);
                    adatok[i].kolis = sorok[2];
                    adatok[i].lakhely = sorok[3];
                }

                Console.WriteLine("Az adatok tömb elemei:");

                for (i = 0; i < kategoriak.Length; i++)
                {
                    Console.WriteLine("{0}   {1}   {2}  {3}", adatok[i].nev, adatok[i].oraber, adatok[i].kolis, adatok[i].lakhely;
                }

                else
                Console.ReadKey();
        }
    }
}
