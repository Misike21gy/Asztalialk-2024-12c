using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szinek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] szinek = { "piros", "kék", "zöld", "sárga", "lila" };
            int i;
            for (i = 0; i < szinek.Length; i++)
            {
                Console.WriteLine(szinek[i]);
            }

            Console.WriteLine("Adj meg egy színt");
            string szin;

            szin=Console.ReadLine();
            while (szin != "0")
            {

                szin = Console.ReadLine();

                int bennevan = 0;
                int ures = 0;
                for (i = 0; i < szinek.Length; i++)
                {
                    if (szin == szinek[i])
                    {
                        Console.WriteLine("Van ilyen szín");
                        bennevan = 1;
                    }
                }

                if (szin == "")
                {
                    ures = 1;
                }

                if (ures == 1)
                {
                    Console.WriteLine("Nem írtál be semmit");
                }
                else

            if (bennevan == 0)
                {
                    Console.WriteLine("Nincs ilyen szín ,vagy hibás adatot adtál meg!");
                }


            }



            Console.ReadKey();


        }
    }
}
