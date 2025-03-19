using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szoftesztdoga_03._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az adóazonosítód: ");
            string adoazonosito = Console.ReadLine();

            if (adoazonosito[0] == '8')
            {
                Console.WriteLine("Ön magánszemély!");
            }

            if (adoazonosito.Length == 10)
            {
                Console.WriteLine("A számsor helyes");
            }
            else
            {
                Console.WriteLine("A számsor helytelen");
            }

            int szam1 = Convert.ToInt32(Convert.ToString(adoazonosito[0]));
            int szam2 = Convert.ToInt32(Convert.ToString(adoazonosito[1]));
            int szam3 = Convert.ToInt32(Convert.ToString(adoazonosito[2]));
            int szam4 = Convert.ToInt32(Convert.ToString(adoazonosito[3]));
            int szam5 = Convert.ToInt32(Convert.ToString(adoazonosito[4]));
            int szam6 = Convert.ToInt32(Convert.ToString(adoazonosito[5]));
            int szam7 = Convert.ToInt32(Convert.ToString(adoazonosito[6]));
            int szam8 = Convert.ToInt32(Convert.ToString(adoazonosito[7]));
            int szam9 = Convert.ToInt32(Convert.ToString(adoazonosito[8]));
            int szam10 = Convert.ToInt32(Convert.ToString(adoazonosito[9]));

            int sz1=szam1*1;
            int sz2 = szam2*2;
            int sz3 = szam3 * 3;
            int sz4 = szam4 * 4;
            int sz5 = szam5 * 5;
            int sz6 = szam6 * 6;
            int sz7 = szam7 * 7;
            int sz8 = szam8 * 8;
            int sz9 = szam9 * 9;

            int osszeg = sz1 + sz2 + sz3 + sz4 + sz5 + sz6 + sz7 + sz8 + sz9;

            Console.WriteLine($"Az eredmény vagyis maradék: {osszeg%11}");

            Console.WriteLine($"Az ellenőrzőszám: {szam10}");

            Console.ReadKey();
        }
    }
}
