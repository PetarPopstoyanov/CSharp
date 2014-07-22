using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort_3_Numbers_with_Nested_Ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            double c = double.Parse(Console.ReadLine());

            if (b >= c && a > b)
            {
                Console.WriteLine("Descending order: {0} {1} {2}", a, b, c);

            }
            else if (b >= c && a < b)
            {
                if (b >= c && a > c)
                    Console.WriteLine("Descending order: {0} {1} {2}", b, a, c);
                else
                    Console.WriteLine("Descending order: {0} {1} {2}", b, c, a);
            }
            else if (b <= c && a > c)
            {
                Console.WriteLine("Descending order: {0} {1} {2}", a, c, b);
            }
            else if (b <= c && a < c)
            {
                if (b <= c && a > b)
                    Console.WriteLine("Descending order: {0} {1} {2}", c, a, b);
                else
                    Console.WriteLine("Descending order: {0} {1} {2}", c, b, a);
            }
        }
    }
}
