using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //[Реализуйте вывод чисел с помощью операторов цикла]
            /*
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            // while:
            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }
            // do while:
            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);
            // for:
            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }
            Console.ReadKey();
            */
            //[Используйте цикл с постусловием]
            /* double x;
             Console.Write("Введите левую границу интервала: ");
             double x1 = Double.Parse(Console.ReadLine());
             Console.Write("Введите правую границу интервала: ");
             double x2 = Double.Parse(Console.ReadLine());
             double y;
             Console.WriteLine("\n x\t\t y");
             x = x1;
             do
             {
                 y = Math.Sin(x);
                 Console.WriteLine("{0:f3}\t\t{1:f3}", x, y);
                 x = x + 0.01;
             }
             while (x <= x2);
             Console.ReadKey();
             */
            //[Используйте цикл с предусловием]
            /* Console.WriteLine("Введите a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Int32.Parse(Console.ReadLine());
            int temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine("НОД = {0}", a);
            Console.ReadKey();
            */
            //[исправленный постусловия]
            /*
            double x;
            Console.Write("Введите левую границу интервала: ");
            double x1 = Double.Parse(Console.ReadLine());
            Console.Write("Введите правую границу интервала: ");
            double x2 = Double.Parse(Console.ReadLine());
            double y;
            Console.WriteLine("\n x\t\t y");
            x = x1;
            while (x <= x2);
            {
                y = Math.Sin(x);
                Console.WriteLine("{0:f3}\t\t{1:f3}", x, y);
                x = x + 0.01;
            }
            Console.ReadKey();
            */
            //[исправленные байесовы сети]
            /*
            Console.Write("Введите a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Int32.Parse(Console.ReadLine());
            temp = a;
            do
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            while (temp != b);
            */
            //Расчет суммы, используя операторы перехода
            /*
            int k = Int32.Parse(Console.ReadLine());
            Console.Write("\nВведите b: ");
            int m = Int32.Parse(Console.ReadLine());
            int s = 0;
            for (i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }
            Console.WriteLine("Сумма чисел равна {0}", s);
            */
        }
    }
}
