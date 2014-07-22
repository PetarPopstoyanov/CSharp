using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Numbers_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter min value:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max value:");
            int max = int.Parse(Console.ReadLine());

            if (min <= max)
            {
                Random random = new Random();

                for (int i = 0; i < a; i++)
                {
                    Console.Write(random.Next(min, max + 1) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
