using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoft_tesztóra
{
    class Program
    {
        static void Main(string[] args)
        {
            double szam;
            string szoveg;

            szoveg = Console.ReadLine();
            bool siker = double.TryParse(szoveg, out szam);
            Console.WriteLine(siker);
            Console.WriteLine(szam);

            int szam2 = 10;
            string szoveg2 = Convert.ToString(szam2);
            Console.WriteLine(szoveg2);

            string taj;
            int i, j;
            int szum = 0;
            taj = "673457015";

            for(i=0; i<=7; i++)
            {
                if ((i +1)%2==1)
                {
                    j = int.Parse(taj[i].ToString());
                    szum = szum + (j*3);
                }
                else
                {
                    j = int.Parse(taj[i].ToString());
                    szum = szum + (j * 7);
                }
            }
            Console.WriteLine(szum);

            int ellenorzes = szum % 10;
            if (ellenorzes == int.Parse(taj[8).ToString()))
                Console.WriteLine("Jó taj");
            else 
                Console.WriteLine("Rossz taj");



            Console.ReadKey();
        }
    }
}
