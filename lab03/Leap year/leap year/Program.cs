using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            long y = long.Parse(Console.ReadLine());
            if (y % 4 == 0)
            {
                if ((y % 100 != 0) || (y % 400 == 0))
                    Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
            else Console.WriteLine("NO");
            Console.ReadKey();
        }
    }
}
