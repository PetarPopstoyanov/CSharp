using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 5 random number, separated by space: ");
            string[] numbers = Console.ReadLine().Split();

            double num1 = double.Parse(numbers[0]);
            double num2 = double.Parse(numbers[1]);
            double num3 = double.Parse(numbers[2]);
            double num4 = double.Parse(numbers[3]);
            double num5 = double.Parse(numbers[4]);

            double sum = num1 + num2 + num3 + num4 + num5;

            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", num1, num2, num3, num4, num5, sum);

            Console.ReadKey();
        }  
    }
}
