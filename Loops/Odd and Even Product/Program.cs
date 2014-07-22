using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 1;
            int odd = 1;

            Console.Write("Please enter n random number, separated by space: ");
            string[] numbers = Console.ReadLine().Split();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);

                if (i % 2 == 0)
                {
                    even *= number;
                }
                else
                {
                    odd *= number;
                }
            }

            if (even == odd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + even);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = " + odd);
                Console.WriteLine("even_product = " + even);
            }
        }
    }
}
