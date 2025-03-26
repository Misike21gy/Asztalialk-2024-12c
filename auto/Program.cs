using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Car auto1 = new Car();
            Console.WriteLine(auto1.color);
            auto1.color = "blue";
            Console.WriteLine(auto1.color);
        }
    }
}
