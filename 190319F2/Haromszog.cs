using System;
using System.Collections.Generic;
using System.Text;

namespace _190319F2
{
    class Haromszog : ISikidom
    {
        public double Kerulet()
        {
            double kerulet = 0;
            double oldal1 = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög egyik oldalát!");
            double oldal2 = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög másik oldalát!!");
            double oldal3 = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög harmadik oldalát!!");
            kerulet = oldal1 + oldal2 + oldal3;
            return kerulet;
        }

        public double Terulet()
        {
            double terulet = 0;
            double oldal1 = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög egyik oldalát!");
            double magassag = AdatBekeres.EllenorzottBekeres<double>("Add meg a háromszög magasságát!");
            terulet = oldal1 * magassag / 2;
            return terulet;
        }
    }
}
