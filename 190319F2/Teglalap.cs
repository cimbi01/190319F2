using System;
using System.Collections.Generic;
using System.Text;

namespace _190319F2
{
    class Teglalap : ISikidom, IHasonlithato
    {
        private double oldal1, oldal2;
        // a random megadja, hogy az adatmegadás random legyen vagy felhasználó adja meg
        public Teglalap(bool random = true) { Beolvas(random); }
        public void Beolvas(bool random)
        {
            if (!random)
            {
                oldal1 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap egyik oldalát!");
                oldal2 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap másik oldalát!");
            }
            else
            {
                Random rnd = new Random();
                oldal1 = rnd.NextDouble() *10;
                oldal2 = rnd.NextDouble() * 10;
            }
        }
        public double Kerulet()
        {
            return (oldal1 + oldal2) * 2;
        }
        public double Terulet()
        {
            return (oldal1 * oldal2);
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
            Console.WriteLine("Síkidom: {0} Kerulet: {1} Terulet: {2}", "Téglalap", Kerulet(), Terulet());
            return base.ToString();
        }
    }
}
