using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teglalap
{
    class Hasab : teglalap
    {
        protected double Talap = 3,
           Tpalast = 6,
           magassag = 12,
           felszin = 0;
        public szamitas(double a, double b, double c)
        {
            this.Talap = a;
            this.Tpalast = b;
            this.magassag = c;
            SetFelszin();
            this.felszin = this.Talap * 2 + this.Tpalast;
        }
        public double GetTerulet() { return this.GetTerulet(); }
    }
}
