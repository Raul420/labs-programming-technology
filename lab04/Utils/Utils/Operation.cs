using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Operation
    {
        public static double TriangleSquare(double a, double b, double c)
        {
            if (istriangle(a, b, c))
            {
                double p = (a + b + c) / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return S;
            }
            else
                return 0;
        }
       private static bool istriangle(double a, double b, double c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0))
                return false;
            else
                return ((a + b > c) && (a + c > b) && (b + c > a));
        }
        private static bool istriangle(double a)
        {
            if (a <= 0)
            {
                return false;
            }
            else
                return true;
        }
        public static double TriangleSquare(double a)
        {
            if (istriangle(a))
                return Math.Sqrt((3 * a / 2) * ((3 * a / 2) - a) * 3);
            else
                return 0;
        }

    }
}
