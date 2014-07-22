using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Result {1} {0}", a, b);
            }
            else
                Console.WriteLine("Result {0} {1}", a, b);

        }
    }
}
