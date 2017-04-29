using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        public struct Distance
        {
            public long ft;
            public long inch;
        }
        static void Main(string[] args)
        {
            Distance first;
            Distance second;
            Distance summary;
            Console.WriteLine("Enter first length in feet and inches");
            first.ft = long.Parse(Console.ReadLine());
            first.inch = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter second length in feet and inches");
            second.ft = long.Parse(Console.ReadLine());
            second.inch = long.Parse(Console.ReadLine());
            summary.ft = first.ft + second.ft + ((first.inch + second.inch) / 12);
            summary.inch = ((first.inch + second.inch) % 12);
            Console.WriteLine("{0} '- {1}''", summary.ft, summary.inch);
        }
    }
}
