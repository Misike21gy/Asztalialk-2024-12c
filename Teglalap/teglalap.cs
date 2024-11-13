using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teglalap
{
    class teglalap
    {
        protected double teruleta = 8,
            teruletb = 4,
            terulet = 0;

        public szamitas(double a, double b)
        {
            this.teruleta = a;
            this.teruleta = b;
            SetTerulet();
            this.terulet = this.teruleta * this.teruletb;
        }
        public double GetTerulet() { return this.GetTerulet(); }
    }
}
