using System;

namespace _190319F2
{
    internal class Haromszog : ISikidom, IHasonlithato
    {
        #region Private Fields

        private readonly double[] oldalak = new double[3];
        private double magassag;
        private int magassagoldalszam;

        #endregion Private Fields

        #region Public Constructors

        // a random megadja, hogy az adatmegadás random legyen vagy felhasználó adja meg
        public Haromszog(bool random = true) { Beolvas(random); }

        #endregion Public Constructors

        #region Public Methods

        public double Kerulet()
        {
            double kerulet = this.oldalak[0] + this.oldalak[1] + this.oldalak[2];
            return kerulet;
        }
        public bool Kisebb(double elem)
        {
            return elem < Program.MIN;
        }
        public bool Nagyobb(double elem)
        {
            return elem > Program.MAX;
        }
        public double Terulet()
        {
            double terulet = this.oldalak[this.magassagoldalszam - 1] * this.magassag / 2;
            return terulet;
        }
        public override string ToString()
        {
            Console.WriteLine("Síkidom: {0} Kerulet: {1} Terulet: {2}", "Háromszög", Kerulet(), Terulet());
            return base.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        private void Beolvas(bool random)
        {
            if (random)
            {
                Random rnd = new Random();
                this.oldalak[0] = rnd.NextDouble() * 10;
                this.oldalak[1] = rnd.NextDouble() * 10;
                this.oldalak[2] = rnd.NextDouble() * 10;
                this.magassagoldalszam = rnd.Next(1, 4);
                this.magassag = rnd.NextDouble() * 10;
            }
            else
            {
                this.oldalak[0] = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög egyik oldalát!");
                this.oldalak[1] = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög másik oldalát!");
                this.oldalak[2] = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög harmadik oldalát!");
                // LEGYEN > 0 && < 4
                this.magassagoldalszam = (int)AdatBekeres.EllenorzottBekeres(4, 0, "Add meg hogy a magasság amit megfogsz adni a háromszög melyik oldalához tartozik!");
                this.magassag = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög " + this.magassagoldalszam + " oldalhoz tartozó magasságát!");
            }
        }

        #endregion Private Methods
    }
}
