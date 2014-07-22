using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());

            double discriminanta = (b * b) - (4 * a * c);
            double sqrtdiscriminanta = Math.Sqrt(discriminanta);
            double x1 = (-b + sqrtdiscriminanta) / (2 * a);
            double x2 = (-b - sqrtdiscriminanta) / (2 * a);
            if (discriminanta < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                Console.WriteLine("x1= {0}", x1);
                Console.WriteLine("x2= {0}", x2);
            }
        }
    }
}
