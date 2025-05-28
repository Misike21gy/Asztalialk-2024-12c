using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoldkihivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teljesites;

            Console.WriteLine("Teszteset1");
            Console.WriteLine("Szia! Add meg a heti zöld utad teljesítményét");
            teljesites = Console.ReadLine();

            if(teljesites.Length <10)
            {
                Console.WriteLine("Hiba! A teljesítménynek legalább 10 karakter hosszúnak kell lennie.");
                return;
            }

            int i;
            int teljesitmeny = 0;
            for (i = 0; i < teljesites.Length; i++)
            {
                if (teljesites[i] == '1')
                {
                    teljesitmeny += 5;
                }
                if (teljesites[i] == '2')
                {
                    teljesitmeny += 4;
                }
                if (teljesites[i] == '3')
                {
                    teljesitmeny += 3;
                }
                if (teljesites[i] == '4')
                {
                    teljesitmeny += 2;
                }
            }

            Console.WriteLine($"Összes zöldpont: {teljesitmeny}");

            if (teljesites.Contains('1') && teljesites.Contains('2') && teljesites.Contains('3') && teljesites.Contains('4'))
            {
                Console.WriteLine(" Szép munka! +5 bónuszpont.");
                teljesitmeny += 5;
            }
            else
            {
                Console.WriteLine("Nem járt bónuszpont.");
            }


            if (teljesitmeny >= 50)
            {
                Console.WriteLine($"Osszesen szerzett pont: {teljesitmeny}");
                Console.WriteLine("Gratulálok, kihivás teljesítve!");
            }
            else
            {
                Console.WriteLine($"Osszesen szerzett pont: {teljesitmeny}");
                Console.WriteLine("Tarts ki, legkozelebb meglesz!");
            }


            Console.ReadKey();
        }
    }
}
