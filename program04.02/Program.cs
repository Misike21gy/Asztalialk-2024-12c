using program0402;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program0402
{
    internal class Program
{
    static void Main(string[] args)
    {
        Tanulo diak1 = new Tanulo();
        Console.WriteLine(diak1.szulev);

        if (diak1.szulev == 2010)
        {
            Console.WriteLine("A diák 2010-ben született");
        }
        else
        {
            Console.WriteLine("A diák nem 2010-ben született");
        }

        Console.ReadKey();
    }
}
}