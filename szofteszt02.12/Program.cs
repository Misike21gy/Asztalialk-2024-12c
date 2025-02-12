using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szofteszt02._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd= new Random();

            int n, i, d1, d2, d3;
            n = 0;
            int anninyert = 0;
            int panninyert = 0;
            int dontetlen = 0;
            bool siker = true;
            int anniosszeg = 0;
            int panniosszeg = 0;

            do
            {

                try
                {
                    Console.WriteLine("Mennyit akarsz játszani?(Csak számot írhatsz be 1 és 50 között!!!");
                    //Csak egész számot!!!
                    n = Convert.ToInt32(Console.ReadLine());
                    siker = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Nem számot adtál meg!");
                }

            }
            while (siker);
            
            


            for (i = 0; i < n; i++)
            {
                do
                {

                    Console.WriteLine("{0}.kör", i + 1);
                    //Anni dob
                    d1 = rnd.Next(1, 6);
                    d2 = rnd.Next(1, 6);
                    d3 = rnd.Next(1, 6);
                    anniosszeg = d1 + d2 + d3;
                    Console.WriteLine("{0} {1} {2}", d1, d2, d3, anniosszeg);

                    // Panni dob
                    d1 = rnd.Next(1, 6);
                    d2 = rnd.Next(1, 6);
                    d3 = rnd.Next(1, 6);
                    panniosszeg = d1 + d2 + d3;
                    Console.WriteLine("{0} {1} {2}", d1, d2, d3, panniosszeg);


                    if (anniosszeg > panniosszeg)
                    {
                        Console.WriteLine("Anni nyert");
                        anninyert++;
                    }
                    else if (panniosszeg > anniosszeg)
                    {
                        Console.WriteLine("Panni nyert");
                        panninyert++;
                    }
                    else
                    {
                        Console.WriteLine("Döntetlen");
                        dontetlen++;
                    }

                } while (anniosszeg==panniosszeg);
                

            }

            Console.WriteLine("Anni nyert: {0} Panni nyert: {1} Döntetlen:{2}", anninyert, panninyert, dontetlen);
            Console.ReadKey();
        }
    }
}
