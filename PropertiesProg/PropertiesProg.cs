using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProg
{
    class PropertiesProg
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "István";
            p.setName("Gábor");
            Console.WriteLine("p.Name:{0}", p.Name);
            Console.WriteLine("p.GetName():{0}",p.getName);
            Console.ReadKey();
        }
    }
}
