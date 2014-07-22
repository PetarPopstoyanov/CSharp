using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumofNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input total number N for summing");
            Console.Write("n = ");
            string nStr = Console.ReadLine();
            int n = int.Parse(nStr);
            double sum = 0;
            for (int counter = 0; counter < n; counter++)
            {
                Console.WriteLine("Input number for summing");
                Console.Write("x = ");
                string xStr = Console.ReadLine();
                double x = double.Parse(xStr);
                sum = sum + x;
            }
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
