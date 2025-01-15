using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetterGetter
{
    class Program
    {
        static void Main(string[] args)
        {

            class Person
        {
            public Person() { }
            public string Name { get; set; }

            private int ID { get => ID; set => ID = 101; }

            private int age;

            public void setAge(int age) { this.age = age; }

            public int getAge()
            {
                return this.age;
            }

            private int gender;

            public void setGender(string gender)
            {
                switch (gender)
                {
                    case "Férfi": this.gender = 1;
                        break;

                    case "Nő":this.gender = 2;
                        break;

                    default:this.gender = 3;
                        break;
                }
            }

            public string getGender()
            {
                switch (this.gender)
                {
                    case 1: return "Férfi";
                    case 2: return "Női";
                    default:return "Ismeretlen";
                }
            }


        }

        class GetterSetterProg
        {
            static void Main(string[] args)
            {
                Person person = new Person();
                person.Name = "Ádám";
                Console.WriteLine(person.Name);

                person.ID = 99;
                Console.WriteLine();
            }

        }



    }
    }
}
