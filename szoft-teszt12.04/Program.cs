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
            int szülev = 0;
            string nev;
            string szh;
            string orszag;
            int eredmeny = 0;

            Console.WriteLine("Add meg a kovetkező adatokat! Kérlek add meg a nevet!");
            nev = Console.ReadLine();

            Console.WriteLine("Mikor született?");
            szülev = Convert.ToInt32(Console.ReadLine());
            eredmeny = 2024 - szülev;
            try (szülev == 1 && szülev == 2 && szülev == int.Parse(szülev[4].ToString());
            {
                Console.WriteLine("Az évszám helyes!");
            }
            catch
            {
                Console.WriteLine("Az évszám helytelen!");
            }
            /*1.helyes e az évszám(4 karakter) 2.hogy szám e 3. hogy 1el vagy 2 vel kezdődik e?(2005,1989*/

            Console.WriteLine("Add meg a születési-halálozási dátumot(pl: 1999-2001)!");
            szh=Console.ReadLine();

            Console.WriteLine("Melyik országban élt?");
            orszag =Console.ReadLine();

            Console.WriteLine($"Üdvözlöm! {nev} jelenleg {eredmeny} éves lenne. {szh}-ig élt az alábbi országban: {orszag}.");

            
    

            Console.ReadKey();

            
        }
    }
}
