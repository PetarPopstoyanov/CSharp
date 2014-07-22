using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Insert second number:");
            int b = int.Parse(Console.ReadLine());

            int result = a > b ? a : b;
            Console.WriteLine(result);
        }
    }
}
