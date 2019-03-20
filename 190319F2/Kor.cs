using System;
using System.Collections.Generic;
using System.Text;

namespace _190319F2
{
    class Kor : ISikidom, IHasonlithato
    {
        private readonly double sugar;
        public Kor() { Beolvas(); }
        public void Beolvas()
        {
            double sugar = AdatBekeres.EllenorzottBekeres<double>("Add meg a Kör sugarát");
        }
        public double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }
        public double Terulet()
        {
            return Math.Pow(sugar, 2) * Math.PI;
        }
        public bool Kisebb(int elem)
        {
            return elem < this.Terulet();
        }

        public bool Nagyobb(int elem)
        {
            return elem > this.Terulet();
        }

        public override string ToString()
        {
            Console.WriteLine("Síkidom: {0} Kerulet: {1} Terulet: {1}", "Kör", Kerulet(), Terulet());
            return base.ToString();
        }
    }
}
