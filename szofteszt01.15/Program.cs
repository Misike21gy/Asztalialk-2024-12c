using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8
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

            bool vanfile = File.Exists("nevek.txt");
            if (vanfile)
            {
                string[] kategoriak = File.ReadAllLines("nevek.txt");



                int i;

                for (i = 0; i < kategoriak.Length; i++)
                {
                    Console.WriteLine(kategoriak[i]);
                }
                Adat[] adatok = new Adat[kategoriak.Length];

                for (i = 1; i < kategoriak.Length; i++)
                {
                    string[] sorok = kategoriak[i].Split(' ');
                    adatok[i].nev = sorok[0];
                    try
                    {
                        adatok[i].oraber = int.Parse(sorok[1]);
                    }
                    catch (Exception e)
                    {
                        adatok[i].oraber = 0;
                    }

                    adatok[i].kolis = sorok[2];
                    adatok[i].lakhely = sorok[3];
                }

                Console.WriteLine("Az adatok tömb elemei:");

                for (i = 1; i < kategoriak.Length; i++)
                {
                    Console.WriteLine("{0}   {1}   {2}  {3}  ", adatok[i].nev, adatok[i].oraber, adatok[i].kolis, adatok[i].lakhely);
                }

                string[] vissza = new string[kategoriak.Length];
                for (i = 0; i < kategoriak.Length; i++)
                {
                    vissza[i] = adatok[i].nev + " " + adatok[i].oraber + " " + adatok[i].kolis + " " + adatok[i].lakhely;
                }

                Console.WriteLine("Az uj string tömb:");
                for (i = 0; i < kategoriak.Length; i++)
                {
                    Console.WriteLine(vissza[i]);
                }
                File.WriteAllLines("vissza.txt", vissza);
            }
            else
                Console.WriteLine("nincs ilyen file");


            Console.ReadKey();
        }
    }
}
