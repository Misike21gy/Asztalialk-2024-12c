using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklesProg
{
    class Program
    {
        static void Main(string[] args)
        {
            //*virtual
            //A virtual kulcsszó azt jelzi, hogy egy metódus, property felülírható egy származtatott osztályban.
            //A virtual tagok alapértelmezett viselkedést biztosítanak az ősosztályban, de a származtatott osztályban az override kulcsszóval módosíthatjujk ezt a viselkedést.
            //*sealed
            //A sealed kulcsszó lezárja az osztályokat vagy metódusokat a további örökléstől vagy felülírástól ezáltal biztosítva a
            //stabilitást és a logikai...

            //Átlagos osztály
        class Allat
        {
            //Properties
            public string Name { get; set; }
            public string Hang { get; set; }

            //Konstruktorok
            public Allat()
            {
                this.Name = "Anonim";
                this.Hang = "Én egy állat vagyok";
            }
            public Allat(string name)
            {
                this.Name = name;
                this.Hang = "Én egy állat vagyok";
            }

            //Metódusok
            public void hangotAd()
            {
                Console.WriteLine("Ezt a Allat.hangotAd() metódus írta ki");
                Console.ReadKey();
            }

            //Virtuális metódus
            public virtual void mozog()
            {
                Console.WriteLine("Ezt a virtuális mozog() metódust írta ki.");
                Console.ReadKey();
            }

            //ok
            class Kutya : Allat
            {
                public Kutya() : base()
                {
                    this.Hang = "En egy kutya vagyok";
                    Console.ReadKey();
                }
            }

            //Átlagos metódus felülírása(shadow hatás)
            public void hangotAd()
            {
                Console.WriteLine("Ezt a Kutya.hangotAd() metódus írta ki.");
                Console.ReadKey();
            }

            //Felül írta a virtuális metódus lezárással 
            public sealed override void mozog()
            {
                Console.WriteLine("Ezt a lezárt mozog() metódus írta ki.");
                Console.ReadKey();
            }

            class Komondor : Kutya
            {
                public Komondor() : base()
                {
                    this.Name = "Komondor";
                }
            }

            //Lezárt metódust nem írhatjuk felül:
            //public override void mozog()

            //Osztály lezárása
            sealed class Macska : Allat
            {
                public Macska()
                {
                    this.Name = "Cicamica";
                }
            }

            //Lezárt osztályból nem származtatható
            //class Sziami: Macska




        }

        }
    }
}
