using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhasab
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Kor osztály felhasználása
            #region 1.objektum
            //1.objektumunk
            kor k1 = new kor(); //Objektum példány létrehozása üresen
            k1.readSugar(15.0); //Sugár megadása
            k1.SetKerulet(); //Kiszámoltatjuk a kerületet
            k1.SetTerulet(); //Kiszámoltatjuk a területet
            
            //A Kor osztály felhasználása
            #region 2.objektum
            kor k2 = new kor(28.7);
            k2.SetKerulet();
            k2.SetTerulet();
            Console.WriteLine($"A {k1.GetSugar()} sugarú körkerülete {k1.GetKerulet()} , területe: {k1.GetTerulet()}");
            #endregion EOf 2.objektumunk


            Console.ReadKey();
        }
    }
}
