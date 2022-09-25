using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Teglalap
    {
        double oldalA;
        double oldalB;

        public double OldalA {get => oldalA;
            set {
                if (value <= 0)
                    throw new ArgumentException($"A {value} nem megfelelő érték!");

                else
                    oldalA = value;
            }
        }
        public double OldalB { get => oldalB;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"A {value} nem megfelelő érték!");

                else
                    oldalB = value;
            }
        }

        public double Kerulet()
        {
            return 2 * (oldalA+oldalB);
        }
        public double Terulet()
        {
            return oldalA * oldalB;
        }
    }
}
