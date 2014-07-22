using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiplication_Sign
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
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a<0 && b<0 && c<0)
            {
                Console.WriteLine("-");            
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if ((a<0 && b>0 && c>0) || (a>0 && b<0 && c>0) || (a>0 && b>0 && c<0))
            {
                Console.WriteLine("-");
            }
            else if ((a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c < 0))
            {
                Console.WriteLine("+");
            }



        }
    }
}
