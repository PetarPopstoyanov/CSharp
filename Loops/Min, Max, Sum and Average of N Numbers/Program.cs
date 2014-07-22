using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Min__Max__Sum_and_Average_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter total numbers for calculating:");
            int a = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double average = 0;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Input a number for calculating:");
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                average = sum / a;
                min = Math.Min(min, number);
                max = Math.Max(max, number);
            }
            Console.WriteLine();
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average =  {0:0.00}", average);
        }
    }
}
