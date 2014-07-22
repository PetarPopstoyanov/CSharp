using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Biggest_of_3_Numbers
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
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (b >= c && a < b)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else if (b <= c && a > c)
            {
                Console.WriteLine("The biggest number is: {0}",a);
            }
            else if (b <= c && a < c)
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
        }
    }
}
