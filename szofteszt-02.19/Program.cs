using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szofteszt_02._19
{
    internal class Program
    {
        static int ellenorzes(string x)
        {
            int jo;
            int joszam;
            int szorzo = 10;
            int osszeg = 0;
            for (int i = 0; i < x.Length; i++)
            {
                bool siker = int.TryParse(x[i].ToString(), out jo);
                if (siker)
                {
                    osszeg = osszeg + (jo * szorzo);
                    szorzo--;
                }
            }

            int osztas;
            osztas = osszeg % 11;

            if (osztas == Convert.ToInt32(x[12].ToString()))
            {
                joszam = 1;
            }
            else
                joszam = 0;



            return joszam;
        }
        static void Main(string[] args)
        {
            string[]kategoriak=File.ReadAllLines("vas.txt");
            string szemszam = "1-980227-1258";
            Console.WriteLine(ellenorzes(szemszam));
            for(int i = 0; i < kategoriak.Length; i++)
            {
                if(ellenorzes(kategoriak[i]) == 0)
                {
                    darab++;
                }

            }
            Console.WriteLine(darab);
            Console.WriteLine(kategoriak.Length);

        }
    }
}

