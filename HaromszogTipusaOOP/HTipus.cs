﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogTipusaOOP
{
    class HTipus
    {
        static void Main(string[] args)
        {
            public double HTipus()
            {
                int a = 0;
                int b = 0;
                int c = 0;
                int eredmeny = 0;

                Console.WriteLine($"Kérem az A oldal számát");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Kérem a B oldal számát");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Kérem a C oldal számát");
                c = Convert.ToInt32(Console.ReadLine());

                eredmeny = a + b + c % 2;
                Console.WriteLine($"A derékszögű háromszög területe: {eredmeny}");

                if (a == b && b == c)
                {
                    Console.WriteLine("Szabályos háromszög");
                }
                else
                {
                    Console.WriteLine("Nem szabályos háromszög");
                }

                if (a < b && b < c)
                {
                    Console.WriteLine("Derékszögű háromszög");
                }
                else
                {
                    Console.WriteLine("Nem Derékszögű háromszög");
                }

                if (a < b && b == c)
                {
                    Console.WriteLine("Egyenlő szárú háromszög");
                }
                else
                {
                    Console.WriteLine("Nem egyenlő szárú háromszög");
                }

                
            }
         


            Console.ReadKey();
        }
    }
}
