using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_shooting
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 0;
            int score = 0;
            Console.WriteLine("Стрельба по мишени");
            while (true)
            {
                Console.WriteLine("Введите x: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                double y = double.Parse(Console.ReadLine());
                length = Math.Sqrt(x * x + y * y);
                if (length <= 1)
                {
                    score += 10;
                }
                else
                {
                    if (length <= 2)
                        score += 5;
                    else
                    {
                        if (length <= 3)
                            score += 1;
                    }
                }
                Console.WriteLine("Набрано {0} очков", score);
            }
        }
    }
}
