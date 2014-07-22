using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            bool prime = true;

            if (n > 100 || n < 0)
            {
                Console.WriteLine("You have entered a number outside the range");
            }
            else if (n == 2 || n == 3 || n == 5 || n == 7)
            {
                prime = true;
            }
            else if (n % 2 == 0 || n % 3 == 0 || n % 4 == 0 || n % 5 == 0 || n % 6 == 0 || n % 7 == 0 || n % 8 == 0 || n % 9 == 0 || n % 10 == 0)
            {
                prime = false;
            }
            Console.WriteLine(prime);
        }
    }
}
