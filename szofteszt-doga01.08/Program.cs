using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szofteszt_doga01._08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nev;
            int szam1 = 0;
            int szam2 = 0;
            int szam3 = 0;
            int osszpont = 0;
            int atlag = 0;

            Console.WriteLine("Add meg a neved!");
            nev = Console.ReadLine();

            try
            {
                Console.WriteLine("Add meg az első dolgozat pontszámát!");
                szam1 = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Hibás adat!");
            }


            try
            {
                Console.WriteLine("Add meg a második dolgozat pontszámát!");
                szam2 = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Hibás adat!");
            }


            try
            {
                Console.WriteLine("Add meg a harmadik dolgozat pontszámát!");
                szam3 = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Hibás adat!");
            }

            if(szam1>0 && szam1<100 && szam2 > 0 && szam2 < 100 && szam3 > 0 && szam3 < 100)
            {
                Console.WriteLine("Megfelelő adatok! Köszi!");
            }
            else
            {
                Console.WriteLine("Érvénytelen pontszám!");
            }


            osszpont = szam1 + szam2 + szam3;
            atlag = osszpont / 3;

            if(osszpont>89){
                Console.WriteLine($"Kedves {nev}! A dolgozataid átlaga: {atlag}. Eredményed: jeles! Szép munka! ");
            }
            if(osszpont>79 && osszpont < 90)
            {
                Console.WriteLine($"Kedves {nev}! A dolgozataid átlaga: {atlag}. Eredményed: jó! Szép munka! ");
            }
            if(osszpont>69 && osszpont < 80)
            {
                Console.WriteLine($"Kedves {nev}! A dolgozataid átlaga: {atlag}. Eredményed: Közepes! ");
            }
            if(osszpont>59 && osszpont < 70)
            {
                Console.WriteLine($"Kedves {nev}! A dolgozataid átlaga: {atlag}. Eredményed: Elégséges! ");
            }
            if(osszpont<60)
            {
                Console.WriteLine($"Kedves {nev}! A dolgozataid átlaga: {atlag}. Eredményed: Elégtelen! ");
            }
            

            Console.ReadKey();

        }
    }
}
