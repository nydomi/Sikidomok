using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Kor
    {
        double sugar;
        double atmero;

        public double Sugar
        {
            get => sugar; set
            {
                if (value <= 0)
                    throw new ArgumentException($"A {value} nem megfelelő érték!");

                else
                    sugar = value;
            }
        }
        public double Atmero { get => sugar *2;}

        public double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }
        public double Terulet()
        {
            return Math.PI * Math.Pow(sugar, 2);
        }
    }
}
