using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoft_teszt12._04
{
    class Program
    {
        static void Main(string[] args)
        {
            string szülev;
            string nev;
            string halev;
            string orszag;
            int eredmeny = 0;

            Console.WriteLine("Add meg a kovetkező adatokat! Kérlek add meg a nevet!");
            nev = Console.ReadLine();

            Console.WriteLine("Mikor született?");
            szülev = Console.ReadLine();

            if (szülev.Length != 4)
            {
                Console.WriteLine("Az évszámnak 4 karakter hosszúnak kell lennie.");
            }

            if (szülev[0] == '1' || szülev[0] == '2')
            {
                Console.WriteLine("Az évszám helyes!");
            }
            else
            {
                Console.WriteLine("Az évszámnak 1-gyel vagy 2-vel kell kezdődnie.");
            }

            try
            {
                int szam = int.Parse(szülev);
            }
            catch (FormatException)
            {
                Console.WriteLine("A beírt adat nem szám.");
            }

            int szülev2=Convert.ToInt32(szülev);
            eredmeny = 2024 - szülev2;

            Console.WriteLine("Melyik országban él?");
            orszag =Console.ReadLine();

            Console.WriteLine("Add meg a halálozási dátumot!");
            halev = Console.ReadLine();

            try
            {
                int szam = int.Parse(halev);
            }
            catch (FormatException)
            {
                Console.WriteLine("A beírt adat nem szám.");
            }

            if (halev[0] == '1' || halev[0] == '2')
            {
                Console.WriteLine("Az évszám helyes!");
            }
            else
            {
                Console.WriteLine($"Üdvözlöm {nev}! Ön {szülev2}-ben született és jelenleg {eredmeny} éves. Az alábbi országban él most: {orszag}.");
                break;
            }

            Console.WriteLine($"Üdvözlöm {nev}! Ön {szülev2}-ben született és jelenleg {eredmeny} éves. {halev}-ig élt az alábbi országban: {orszag}.");

            
    

            Console.ReadKey();

            
        }
    }
}
