using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snooker
{
    internal class Program
    {
        struct Adat
        {

            public int helyezes;
            public string nev;
            public string orszag;
            public int nyeremeny;

        }

        static void Main(string[] args)
        {
            string[] kategoriak = File.ReadAllLines("snooker.txt");

            int i;

            for (i = 0; i < kategoriak.Length; i++)
            {
                Console.WriteLine(kategoriak[i]);
            }

            Adat[] adatok = new Adat[kategoriak.Length];

            for (i = 0; i < kategoriak.Length; i++)
            {
                string[] sorok = kategoriak[i].Split(';');
                adatok[i].helyezes = int.Parse(sorok[0]);
                adatok[i].nev = sorok[1];
                adatok[i].orszag = sorok[2];
                adatok[i].nyeremeny = int.Parse(sorok[3]);
 

            }

            Console.WriteLine("Az adatok tömb elemei:");

            for (i = 0; i < kategoriak.Length; i++)
            {
                Console.WriteLine("{0}   {1}   {2}  {3}", adatok[i].helyezes, adatok[i].nev, adatok[i].orszag, adatok[i].nyeremeny);
            }

            //3.feladat
            //A kategoriak.Length-el számolunk
            Console.WriteLine($"A világranglistán {kategoriak.Length} versenyző szerepel.");

            //4.feladat

            double atlag;
            int osszeg= 0;

            for (i = 0; i < kategoriak.Length; i++)
            {
                osszeg = osszeg + adatok[i].nyeremeny;
            }

            atlag = osszeg / kategoriak.Length;

            Console.WriteLine(atlag);

            //5.feladat
            int maxertek = -1;
            int maxindex;

            for (i = 0; i < kategoriak.Length; i++)
            {
                if (adatok[i].orszag == "Kína")
                {
                    if (adatok[i].nyeremeny>maxertek)
                    {
                        maxertek=adatok[i].nyeremeny;
                        maxindex = i;
                    }
                }
            }
            Console.WriteLine(" {0} {1} {2} {3}", adatok[maxindex].nev, adatok[maxindex].helyezes, adatok[maxindex].orszag, adatok[maxindex].nyeremeny);

            //6.feladat
            bool bennevan = false;
            int j = 0;
            while (j < 99 && adatok[j].orszag!="Norvégia")
            {
                j++;
            }

            if (adatok[j].orszag=="Norvégia")
            {
                Console.WriteLine("Van norvég versenyző a világranglistán.");
            }
            else
            {
                Console.WriteLine("Nincs norvég versenyző a világranglistán.");
            }



                Console.ReadKey();
        }
    }
}
