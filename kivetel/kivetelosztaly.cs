using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetel
{
    class kivetelosztaly
    {
        public void KivKezNincs()
        {
            Console.WriteLine("Nincs kivételkezeles\n Adjon meg egy értéket!");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A beírt szám{0}", szam);

        }

        public void KivKezAlt()
        {
            Console.WriteLine("\nHiba objektum nélküli kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: szam}", szam);
            }
            catch
            {
                throw;
            }
        }

        public void KivKezOs()
        {
            Console.WriteLine("\nŐs Hiba objektummal kivételkezelés\n Adjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch(Exception e)
            {
                Console.WriteLine();
            }
        }
    Console.ReadKey();
    }
}
