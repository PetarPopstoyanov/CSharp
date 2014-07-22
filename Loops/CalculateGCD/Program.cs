using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = int.Parse(Console.ReadLine());

            int c = 0;
            while (b!=0)
            {
                c = b;
                b = a % b;
                a = c;
            }
            Console.WriteLine("GCD is: " + a);
        }
    }
}
