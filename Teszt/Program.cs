using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] teszt= File.ReadAllLines("macska.txt");
            if (File.Exists("macska.txt" ) ==true)
            {
                Console.WriteLine("A fájl létezik");
            }
            else
            {
                Console.WriteLine("A fájl nem létezik");
            }
            Console.WriteLine(teszt);
            if (teszt[3][0] == 'f')
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nincs");
            }
            Console.ReadKey();
        }
    }
}
