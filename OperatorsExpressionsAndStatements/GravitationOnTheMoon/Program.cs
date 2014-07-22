using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight:");
            double a = double.Parse(Console.ReadLine());
            double b = a * 0.17;
            Console.WriteLine("Your weight on the moon will be: {0}", b);
        }
    }
}
