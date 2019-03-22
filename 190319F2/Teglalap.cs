using System;

namespace _190319F2
{
    internal class Teglalap : ISikidom, IHasonlithato
    {
        #region Private Fields

        private double oldal1, oldal2;

        #endregion Private Fields

        #region Public Constructors

        // a random megadja, hogy az adatmegadás random legyen vagy felhasználó adja meg
        public Teglalap(bool random = true) { Beolvas(random); }

        #endregion Public Constructors

        #region Public Methods

        public void Beolvas(bool random)
        {
            if (!random)
            {
                this.oldal1 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap egyik oldalát!");
                this.oldal2 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap másik oldalát!");
            }
            else
            {
                Random rnd = new Random();
                this.oldal1 = rnd.NextDouble() * 10;
                this.oldal2 = rnd.NextDouble() * 10;
            }
        }
        public double Kerulet()
        {
            return (this.oldal1 + this.oldal2) * 2;
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
            return (this.oldal1 * this.oldal2);
        }
        public override string ToString()
        {
            Console.WriteLine("Síkidom: {0} Kerulet: {1} Terulet: {2}", "Téglalap", Kerulet(), Terulet());
            return base.ToString();
        }

        #endregion Public Methods
    }
}
