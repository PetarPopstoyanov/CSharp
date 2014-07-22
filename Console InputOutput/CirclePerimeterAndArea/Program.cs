using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert radius = ");
            double r = double.Parse(Console.ReadLine());

            double perimetar = 2 * 3.14 * r;
            double area = 3.14 * r * r;
            Console.WriteLine("Perimetar: {0:0.00}", perimetar);
            Console.WriteLine("Area: {0:0.00}", area);
        }
    }
}
