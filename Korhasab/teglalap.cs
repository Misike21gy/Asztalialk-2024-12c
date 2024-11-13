using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhasab
{
    class teglalap
    {
        public void teglalap()
        {
            int kerulet = 0;
            int terulet = 0;

            int a = 5;
            int b = 3;

            kerulet = a + b * 2;
            terulet = a * b;

            Console.WriteLine($"A kerület eredménye: {kerulet}, és a terület számítás eredménye: {terulet}.");
        }
    }
}
