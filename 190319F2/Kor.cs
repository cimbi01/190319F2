using System;
using System.Collections.Generic;
using System.Text;

namespace _190319F2
{
    class Kor : ISikidom, IHasonlithato
    {
        private double sugar;
        public Kor(bool random = true) { Beolvas(random); }
        public void Beolvas(bool random)
        {
            if(!random) this.sugar = AdatBekeres.EllenorzottBekeres<double>("Add meg a Kör sugarát");
            else this.sugar = new Random().NextDouble() * 10;
        }
        public double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }
        public double Terulet()
        {
            return Math.Pow(sugar, 2) * Math.PI;
        }
        public bool Kisebb(double elem)
        {
            return elem < Program.MIN;
        }

        public bool Nagyobb(double elem)
        {
            return elem > Program.MAX;
        }

        public override string ToString()
        {
            Console.WriteLine("Síkidom: {0} Kerulet: {1} Terulet: {2}", "Kör", Kerulet(), Terulet());
            return base.ToString();
        }
    }
}
