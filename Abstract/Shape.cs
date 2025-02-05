using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ez a példa az Abstract kulcsszó használatát mutatja be.
 * Az abstract kulcsszóval oylan sosztályokat és metódusokat jelölünk , amelyeket nem lehet közvetlenül pédányosítani, illetve végrehajtani. Az abstract osztályokat alapként használjuk más osztályok számára, míg az abstract metódusok deklarációkat tartalmaznak, de nem adnak meg implementációt.
 * 
 * Fontos jellemzők:
 * -Abstract osztály: Csak származtatott osztályokon használható. Tartalmazhat absztrakt és nem absztrakt(működő) metódusokat is.
 * -Abstrtact metódus: Csak abszztrakt osztályban lehet, és a származtatott osztálynak kötelező megvalósítania.
 */
namespace Abstract
{
    abstract class Shape
    {
        //Abstract metódus-nincs implementáció
        //Ennek a kódját a leszármazottbam kötelező megírni!
        public abstract double GetArea();

        //Normál metódus
        public void DisplayShape()
        {
            Console.WriteLine("Ez egy alakzat");
        }

        class Circle : Shape
        {
            private double sugar;
            public Circle(double r)
            {
                this.sugar = r;
            }
        }


        //Abstract metódus implementálása
        public override double GetArea()
        {
            return Math.PI * sugar;
        }
    }

    class Program { 

        static void Main(string[] args)
        {
            //Shape pédányosítása nem lehetséges:
            //Shape shape = new Shape(); //Fordítási hiba!

            //Circle példányosítása:
            Circle circle = new Circle(5);
            Console.WriteLine("A kör területe:" + circle.GetArea());
            circle.DisplayShape();  //A DisplayShape metódust a szülő osztályból hívja meg.

            Console.ReadKey();
        }
    }
}
