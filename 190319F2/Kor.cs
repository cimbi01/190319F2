using System;
using System.Collections.Generic;
using System.Text;

namespace _190319F2
{
    class Kor : ISikidom
    {
        public double Kerulet()
        {
            double sugar = AdatBekeres.EllenorzottBekeres<double>("Add meg a Kör sugarát");
            return 2 * sugar * Math.PI;
        }

        public double Terulet()
        {
            double sugar = AdatBekeres.EllenorzottBekeres<double>("Add meg a Kör sugarát");
            return Math.Pow(sugar, 2) * Math.PI;
        }
    }
}
