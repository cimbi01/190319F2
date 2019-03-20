using System;
using System.Collections.Generic;
using System.Text;

namespace _190319F2
{
    class Teglalap : ISikidom, IHasonlithato
    {
        private readonly double oldal1, oldal2;
        public Teglalap() { Beolvas(); }
        public void Beolvas()
        {
            double oldal1 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap egyik oldalát!");
            double oldal2 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap másik oldalát!");
        }
        public double Kerulet()
        {
            return (oldal1 + oldal2) * 2;
        }

        public double Terulet()
        {
            return (oldal1 * oldal2);
        }
        public bool Kisebb(int elem)
        {
            return elem < Terulet();
        }

        public bool Nagyobb(int elem)
        {
            return elem < Terulet();
        }
        public override string ToString()
        {
            Console.WriteLine("Síkidom: {0} Kerulet: {1} Terulet: {1}", "Téglalap", Kerulet(), Terulet());
            return base.ToString();
        }
    }
}
