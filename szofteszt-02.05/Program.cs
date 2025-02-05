using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace szofteszt_02._05
{
    class Program
    {
        struct Adat
        {
            public string Versenyzo;
            public int Rajtszam;
            public string Kategoria;
            public string Versenyido;
            public int TavSzazalek;
        }

        static double idoOraban(string ido)
        {
            string[] idosor = ido.Split(';');
            double o = double.Parse(idosor[0]);
            double p = double.Parse(idosor[1]);
            double masodperc = double.Parse(idosor[2]);

            ms = ((o * 3600) + (p * 60) + masodperc);

            return ms;
        }

        static void Main(string[] args)
        {
            string[] kategoriak = File.ReadAllLines("ub2017egyeni.txt");



            int i;

            for (i = 0; i < kategoriak.Length; i++)
            {
                Console.WriteLine(kategoriak[i]);
            }
            Adat[] adatok = new Adat[kategoriak.Length];

            for (i = 1; i < kategoriak.Length; i++)
            {
                string[] sorok = kategoriak[i].Split(';');
                adatok[i].Versenyzo = sorok[0];
                adatok[i].Rajtszam = int.Parse(sorok[1]);
                adatok[i].Kategoria = sorok[2];
                adatok[i].Versenyido = sorok[3];
                adatok[i].TavSzazalek = int.Parse(sorok[4]);
            }

            Console.WriteLine("Az adatok tömb elemei:");

            for (i = 1; i < kategoriak.Length; i++)
            {
                Console.WriteLine("{0}   {1}   {2}  {3}  {4}", adatok[i].Versenyzo, adatok[i].Rajtszam, adatok[i].Kategoria, adatok[i].Versenyido, adatok[i].TavSzazalek);
            }

            Console.WriteLine(kategoriak.Length-1);
            int db = 0;
            for(i = 1; i < kategoriak.Length; i++)
            {
                if (adatok[i].Kategoria == "Noi" && adatok[i].TavSzazalek == 100);
                    db++;
            }
            Console.WriteLine(db);
            Console.WriteLine("Add meg a nevet: ");
            string nev = Console.ReadLine();
            for (i = 1; i < kategoriak.Length; i++)
            {
                if (nev == adatok[i].Versenyzo)
                {
                    Console.WriteLine("Indult egyéniben a sportoló? Igen!");
                    Console.WriteLine("Teljesítette a távot?");
                    if (adatok[i].TavSzazalek == 100)
                    {
                        Console.WriteLine("Igen!");
                    }
                    else Console.WriteLine("Nem!");
                }
            }

            Console.WriteLine(idoOraban(adatok[3].Versenyido));
                Console.ReadKey();



        }
    }
}

