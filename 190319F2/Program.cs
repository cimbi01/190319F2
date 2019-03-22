using System;

namespace _190319F2
{
    internal class Program
    {
        #region Public Fields

        public const double MAX = 100;
        public const int MIN = 10;

        #endregion Public Fields

        #region Private Fields

        private static readonly ISikidom[] sikidomok = new ISikidom[3];

        #endregion Private Fields

        #region Private Methods

        // sikidomok letrehozasa ha random igaz akkor random adja meg az adatokat ha hamis akkor
        // felhasználó adja meg
        private static void Init(bool random)
        {
            //síkidomok létrehozása
            sikidomok[0] = new Kor(random); ;
            sikidomok[1] = new Haromszog(random);
            sikidomok[2] = new Teglalap(random);
        }

        private static void Main(string[] args)
        {
            bool random = AdatBekeres.EldöntendoBekeres("Szeretnéd random megadni a Sikidomok adatait?\nNyomj entert, ha igen", "");
            Init(random);
            int nagyobb = 0, kisebb = 0;
            foreach (ISikidom sikidom in sikidomok)
            {
                IHasonlithato hasonsik = sikidom as IHasonlithato;
                if (hasonsik.Nagyobb(sikidom.Terulet()))
                {
                    nagyobb++;
                }

                if (hasonsik.Kisebb(sikidom.Terulet()))
                {
                    kisebb++;
                }

                sikidom.ToString();
            }
            if (nagyobb > 0)
            {
                Console.WriteLine("Van síkidom, ami nagyobb!");
            }
            else
            {
                Console.WriteLine("Nincs síkidom, ami nagyobb");
            }

            Console.WriteLine("Kisebb: {0}", kisebb);
            Console.ReadKey();
        }

        #endregion Private Methods
    }
}
