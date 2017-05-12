using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadric_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;
            Console.WriteLine("Input three parameters for a function:");
            int ans2 = Methods.QuadricEquation(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()), out x1, out x2);
            switch (ans2)
            {
                case -1:
                    Console.WriteLine("Ошибка: Discriminant < 0");
                    break;
                case 0:
                    Console.WriteLine("Ответ: x = {0}", x1);
                    break;
                case 1:
                    Console.WriteLine("Ответ: x1 = {0} x2 = {1}", x1, x2);
                    break;
                default:
                    Console.WriteLine("Fatal error!");
                    return;
            }
            Console.ReadKey();
        }
    }
    class Methods
    {
        public static int QuadricEquation(double a, double b, double c, out double x1, out double x2)
        {
            x1 = 0; x2 = 0;
            double disc = Math.Sqrt(b * b - 4 * a * c);
            if (Double.IsNaN(disc))
                return -1;
            x1 = (-b + disc) / (2 * a);
            if (disc == 0)
            {
                x2 = x1;
                return 0;
            }
            x2 = (-b - disc) / (2 * a);
            return 1;
        }
    }
}
