using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("SideA = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("SideB = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Height = ");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine("The trapezoid's area is: " + area);
        }
    }
}
