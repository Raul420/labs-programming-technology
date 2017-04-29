using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_05
{
    class Program
    {
        static void Main(string[] args)
        {
            try {Console.WriteLine("Please enter the triangle's perimeter");
            string temp = Console.ReadLine();
            double P = double.Parse(temp);
            double p = P / 2;
            double a = P / 3;
            double S = Math.Sqrt(p * (p - a)*(p - a)*(p - a));
            Console.WriteLine("SIDE\tSQUARE");
            Console.WriteLine("{0:0.##}\t{1:0.##}", a, S);
            Console.Read(); }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
        }
    }
}
