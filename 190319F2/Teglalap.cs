using System;
using System.Collections.Generic;
using System.Text;

namespace _190319F2
{
    class Teglalap : ISikidom
    {
        public double Kerulet()
        {
            double oldal1 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap egyik oldalát!");
            double oldal2 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap másik oldalát!");
            return (oldal1 + oldal2) * 2;
        }

        public double Terulet()
        {
            double oldal1 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap egyik oldalát!");
            double oldal2 = AdatBekeres.EllenorzottBekeres<double>("Add meg a téglalap másik oldalát!");
            return (oldal1 * oldal2);
        }
    }
}
