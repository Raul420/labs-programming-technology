using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите первое число:");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число:");
            //int y = int.Parse(Console.ReadLine());
            //int greater = Utils.Greater(x, y);
            //Console.WriteLine("Большим из чисел {0} и {1} является {2} ", x, y, greater);
            //Utils.Swap(ref x, ref y);
            //Console.WriteLine("До swap: \t" + x + " " + y);
            //Utils.Swap(ref x, ref y);
            //Console.WriteLine("После swap: \t" + x + " " + y);
            //int f;
            //bool ok;
            //Console.WriteLine("Number for factorial:");
            //int x = int.Parse(Console.ReadLine());
            //// Test the factorial function
            //ok = Utils.Factorial(x, out f);
            //// Output factorial results
            //if (ok)
            //    Console.WriteLine("Factorial(" + x + ") = " + f);
            //else
            //    Console.WriteLine("Cannot compute this factorial");
            Console.WriteLine("Выберите тип треугольника:\nРавносторонний: введите true\nНе равносторонний: введите false");
            bool tip = bool.Parse(Console.ReadLine());
            double S;
            if (tip)
            {
                Console.WriteLine("Введите сторону треугольника: ");
                double a = double.Parse(Console.ReadLine());
                S = (Operation.TriangleSquare(a));
                Console.WriteLine("Площадь треугольника равна {0} ", S);
            }
            else
            {
                Console.WriteLine("Введите стороны треугольника: ");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                S = (Operation.TriangleSquare(a, b, c));
                Console.WriteLine("Площадь треугольника равна {0} ", S);
            }
            Console.ReadKey();
        }
    }
}
