using System;

namespace _190319F2
{
    class Program
    {
        public const double MAX = 100;
        public const int MIN = 10;
        private static readonly ISikidom[] sikidomok = new ISikidom[3];
        static void Main(string[] args)
        {
            Init();
            int nagyobb = 0, kisebb = 0;
            foreach (ISikidom sikidom in sikidomok)
            {
                // IHasonlithato toString-et mindig meghívja
                IHasonlithato hasonsik = sikidom as IHasonlithato;
                if (hasonsik.Nagyobb(sikidom.Terulet())) nagyobb++;
                if (hasonsik.Kisebb(sikidom.Terulet())) kisebb++;
                sikidom.ToString();
            }
            if (nagyobb > 0)
                Console.WriteLine("Van síkidom, ami nagyobb!");
            else
                Console.WriteLine("Nincs síkidom, ami nagyobb");
            Console.WriteLine("Kisebb: {0}", kisebb);
            Console.ReadKey();
        }
        private static void Init()
        {
            //síkidomok létrehozása
            sikidomok[0] = new Kor(); ;
            sikidomok[1] = new Haromszog();
            sikidomok[2] = new Teglalap();
        }
    }
}
