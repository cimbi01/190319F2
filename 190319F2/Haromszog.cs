using System;
using System.Collections.Generic;
using System.Text;

namespace _190319F2
{
    class Haromszog : ISikidom, IHasonlithato
    {
        private readonly double[] oldalak = new double[3];
        private double magassag;
        private int magassagoldalszam;
        public Haromszog(){ this.Beolvas(); }
        private void Beolvas()
        {
            oldalak[0] = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög egyik oldalát!");
            oldalak[1] = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög másik oldalát!");
            oldalak[2] = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög harmadik oldalát!");
            magassagoldalszam = AdatBekeres.EllenorzottBekeres<int>("Add meg hogy a magasság amit megfogsz adni a háromszög melyik oldalához tartozik!");
            magassag = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög 1. oldalhoz tartozó magasságát!");
        }
        public double Kerulet()
        {
            double kerulet = oldalak[0] + oldalak[1] + oldalak[2];
            return kerulet;
        }

        public double Terulet()
        {
            double terulet = oldalak[magassagoldalszam-1] *  magassag /  2;
            return terulet;
        }

        public bool Nagyobb(int elem)
        {
            return elem < Terulet();
        }

        public bool Kisebb(int elem)
        {
            return elem > Terulet();
        }
        public override string ToString()
        {
            Console.WriteLine("Síkidom: {0} Kerulet: {1} Terulet: {1}", "Háromszög", Kerulet(), Terulet());
            return base.ToString();
        }
    }
}
