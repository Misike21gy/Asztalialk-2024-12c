﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhasab
{
    class kor
    {
        //Az osztály feladata a sugárból kiszámolja a kör kerületét, és területét.

        //Osztályváltozók
        protected double sugar,
            kerulet,
            terulet;
        //Konstruktorok
        public kor()
        {

        }

        public kor(double r)
        {
            this.sugar = r;
        }

        //Metódusok
        public void readSugar(double r)
        {
            this.sugar = r;
        }

        public void SetKerulet()
        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }

        public void SetTerulet()
        {
            double eredmeny1 = 0.0,
                eredmeny2 = 0.0;

            eredmeny1 = this.sugar * this.sugar * Math.PI;

            eredmeny2 = Math.Pow(this.sugar, 2)*Math.PI;

            if (eredmeny1==eredmeny2)
            {
                this.terulet = eredmeny1;
            }
            else
            {
                Console.WriteLine($"Eredmény1{eredmeny1}!=Eredmény2{eredmeny2}");
            }
        }
        public double GetKerulet() { return this.kerulet; }
        public double GetTerulet() { return this.terulet; }
        public double GetSugar() { return this.sugar; }




    }

    class Henger : kor
    {
        private double magasság,
            térfogat;
        public Henger(double r,double m)
        {
            this.sugar = r;
            this.magasság = m;
            SetTerulet();
            this.térfogat = this.SetTerulet * this.magasság;
        }
        public double GetTérfogat() { return this.GetTérfogat(); }
        public double GetMagasság() { return this.magasság; }
    }
}
