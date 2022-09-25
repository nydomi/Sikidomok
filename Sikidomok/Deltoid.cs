using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Deltoid
    {
        double oldalA;
        double oldalB;
        double kozbezartSzog;

        public double OldalA { get => oldalA; set => oldalA = value; }
        public double OldalB { get => oldalB; set => oldalB = value; }
        public double KozbezartSzog { get => kozbezartSzog; set => kozbezartSzog = value; }

        public double Kerulet()
        {
            return 2 * (oldalA + oldalB);
        }
        public double Terulet()
        {
            return oldalA * oldalB * Math.Sin(kozbezartSzog);
        }
    }
}
