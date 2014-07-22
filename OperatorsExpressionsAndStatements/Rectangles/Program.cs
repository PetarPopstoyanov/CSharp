using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Width = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Height = ");
            double b = double.Parse(Console.ReadLine());

            double perimeter = (2 * a) + (2 * b);
            double area = a * b;

            Console.WriteLine("Perimeter of rectangle is " + perimeter);
            Console.WriteLine("Area of rectangle is " + area);

        }
    }
}
