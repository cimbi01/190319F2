using System;

namespace _190319F2
{
    internal class Kor : ISikidom, IHasonlithato
    {
        #region Private Fields

        private double sugar;

        #endregion Private Fields

        #region Public Constructors

        // a random megadja, hogy az adatmegadás random legyen vagy felhasználó adja meg
        public Kor(bool random = true) { Beolvas(random); }

        #endregion Public Constructors

        #region Public Methods

        public void Beolvas(bool random)
        {
            if (!random)
            {
                this.sugar = AdatBekeres.EllenorzottBekeres<double>("Add meg a Kör sugarát");
            }
            else
            {
                this.sugar = new Random().NextDouble() * 10;
            }
        }
        public double Kerulet()
        {
            return 2 * this.sugar * Math.PI;
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
            return Math.Pow(this.sugar, 2) * Math.PI;
        }
        public override string ToString()
        {
            Console.WriteLine("Síkidom: {0} Kerulet: {1} Terulet: {2}", "Kör", Kerulet(), Terulet());
            return base.ToString();
        }

        #endregion Public Methods
    }
}
