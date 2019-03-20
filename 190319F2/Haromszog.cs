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
        public Haromszog(bool random = true){ this.Beolvas(random); }
        private void Beolvas(bool random)
        {
            if (random)
            {
                Random rnd = new Random();
                oldalak[0] = rnd.NextDouble()*10;
                oldalak[1] = rnd.NextDouble() * 10;
                oldalak[2] = rnd.NextDouble() * 10;
                // LEGYEN > 0 && < 4
                magassagoldalszam = rnd.Next(1, 4);
                magassag = rnd.NextDouble() * 10;
            }
            else
            {
                oldalak[0] = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög egyik oldalát!");
                oldalak[1] = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög másik oldalát!");
                oldalak[2] = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög harmadik oldalát!");
                // LEGYEN > 0 && < 4
                magassagoldalszam = AdatBekeres.EllenorzottBekeres<int>("Add meg hogy a magasság amit megfogsz adni a háromszög melyik oldalához tartozik!");
                magassag = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög " + magassagoldalszam + " oldalhoz tartozó magasságát!");
            }
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
            Console.WriteLine("Síkidom: {0} Kerulet: {1} Terulet: {2}", "Háromszög", Kerulet(), Terulet());
            return base.ToString();
        }
    }
}
