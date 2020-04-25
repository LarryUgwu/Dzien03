using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    class Trojkat : Figura
    {
        //pola
        private double? bokA = null;  //dopuszczamy wartość nullową
        private double? bokB = null;
        private double? bokC = null;
        private double? wysokosc = null;

        //konstruktor
        public Trojkat(double a, double b, double c)
        {
            bokA = a;
            bokB = b;
            bokC = c;
            liczbaBokow = 3;
        }

        public Trojkat(double a, double h)
        {
            bokA = a;
            wysokosc = h;
        }

        public double ObliczPole()
        {
            if ( bokA != null && wysokosc != null)
            {
                return 0.5 * (double)bokA * (double)wysokosc;
            }
            else
            {
                double p = 0.5 * ((double)bokA + (double)bokB + (double)bokC);
                return Math.Sqrt(p * (p - (double)bokA) * (p - (double)bokB) * (p - (double)bokC));
            }
        }

        public double ObliczObwód()
        {
            if (wysokosc != null)
            {
                return 0;
            }
            else
            {
                return (double)bokA + (double)bokB + (double)bokC;
            }
        }
    }
}
