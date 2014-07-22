using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOf3Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int c = int.Parse(Console.ReadLine());

            int d = a + b + c;
            Console.WriteLine("The sum is: " + d);
        }
    }
}
