using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Rombusz
    {
        double oldalA;
        double magassag;

        public double OldalA { get => oldalA; set => oldalA = value; }
        public double Magassag { get => magassag; set => magassag = value; }

        public double Terulte()
        {
            return oldalA * magassag;
        }
        public double Kerulet()
        {
            return 4 * oldalA; 
        }
    }
}
