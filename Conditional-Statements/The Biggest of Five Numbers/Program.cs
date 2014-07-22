using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Biggest_of_Five_Numbers
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
            Console.WriteLine("Enter fourth number:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth number:");
            double e = double.Parse(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else if (c >= a && c >= b && c >= d && c >= e) 
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine("The biggest number is: {0}", d);
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine("The biggest number is: {0}", e);
            }
        }
    }
}
