using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szofteszt_alakzat
{
    class Program
    {
        static int szamol(int x)
        {
            return x+++;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            int valasztas;
            int szamolas = 0;

            do
            {
                Console.WriteLine("Próbálkozások száma: {0}", x++;
                Console.WriteLine("Válassz síkidomot a szám alapján");
                Console.WriteLine("1.Háromszög 2.Téglalap 3.Négyzet 4.Rombusz 5.Paralelogramma 6.Trapéz 0.Kilépés");

                try
                {
                    int valasztas = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    valasztas = 9;
                }

                
                switch (valasztas)
                {
                    case1:
                        Console.WriteLine("add meg az adatokat: ");
                        Console.WriteLine("a:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("b:");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("c:");
                        c = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"A kerülete: {a + b + c}");
                        break;

                    case2:
                        Console.WriteLine("add meg az adatokat: ");
                        Console.WriteLine("a:");
                        a = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"A területe: {a + a + a + a}");
                        break;


                    case3:
                        Console.WriteLine("add meg az adatokat: ");
                        Console.WriteLine("a:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("b:");
                        b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"A területe: {a + b * 2}");
                        break;

                    case0:
                        Console.WriteLine("");
                        break;

                        default:
                        Console.WriteLine("Nincs ilyen választási opció");
                        break; 

            }

                    while (valasztas! = 0);
                    Console.WriteLine("Kiléptél");

                    Console.ReadKey();
        }
    } 
     
 }

