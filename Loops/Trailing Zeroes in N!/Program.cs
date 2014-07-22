using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trailing_Zeroes_in_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n!:");
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger factN = 1;

            for (BigInteger i = 1; i <= n; i++)
            {
                factN = i * factN;
            }
            Console.WriteLine("Trailing zeroes in n! = " + (n / 5));
            Console.WriteLine(factN);
        }

    }
}
