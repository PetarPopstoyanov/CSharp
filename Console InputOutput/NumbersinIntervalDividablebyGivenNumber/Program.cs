using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersinIntervalDividablebyGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start Number:");
            long start = long.Parse(Console.ReadLine());
            Console.Write("Enter end number:");
            long end = long.Parse(Console.ReadLine());
            int count = 0;
            for (long i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
