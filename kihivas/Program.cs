using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kihivas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aktivitas;

            int teljesitmeny = 0;

            int i;

            bool plusz = false;

            // Úszás U 1 km
            //Gyaloglás G 1 km
            //Futás F 2 km
            //Kerékpározás K 10 km


            Console.WriteLine("Üdv! Hogy ment a mozgás? Írd le a heti mozgásod a megadott betűk alapján én pedig máris értékelem neked! ");
            aktivitas=Console.ReadLine();

            
            for (i = 0; i < aktivitas.Length; i++)
            {
                if (aktivitas[i] == 'U')
                {
                    teljesitmeny += 1;
                }
                if (aktivitas[i] == 'G')
                {
                    teljesitmeny += 1;
                }
                if (aktivitas[i] == 'F')
                {
                    teljesitmeny += 2;
                }
                if (aktivitas[i] == 'K')
                {
                    teljesitmeny += 10;
                }
            }


            Console.WriteLine($"A héten elért távolsága: {teljesitmeny}km !");

            if (aktivitas.Contains("U") && aktivitas.Contains("G") && aktivitas.Contains("F") && aktivitas.Contains("K"))
            {
                Console.WriteLine("Bravó! Jutalma még 10 km. Ügyes voltál!");
                plusz = true;
            }
            else
            {
                Console.WriteLine("Sajnos most nem jár jutalom!"); 
            }



            if (plusz == true && teljesitmeny > 40)
            {
                Console.WriteLine($"Eredménye: {teljesitmeny + 10}. Gratulálok, kihívás teljesítve!");
            }
            else
            {
                if (teljesitmeny > 40 && plusz == false)
                {
                    Console.WriteLine($"Eredménye: {teljesitmeny}. Gratulálok, kihívás teljesítve!");
                }
                if (teljesitmeny < 40 && plusz == true)
                {
                    Console.WriteLine($"Eredménye: {teljesitmeny+10}. Legközelebb sikerül!");
                }
                if (teljesitmeny < 40 && plusz == false)
                {
                    Console.WriteLine($"Eredménye: {teljesitmeny}. Legközelebb sikerül!");
                }
                if (teljesitmeny == 40 && plusz == false)
                {
                    Console.WriteLine($"Eredménye: {teljesitmeny}. Gratulálok, kihívás teljesítve!");
                }
            }



            Console.ReadKey();
        }
    }
}
