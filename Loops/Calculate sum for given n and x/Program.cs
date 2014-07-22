using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate_sum_for_given_n_and_x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x:");
            int x = int.Parse(Console.ReadLine());

            double sum = 1;
            double facturiel = 1;
            double xpowern = 1;

            for (int i = 1; i <=n; i++)
            {
                facturiel = i * facturiel;
                xpowern = x * xpowern;
                sum = sum + (facturiel / xpowern);
            }
            Console.WriteLine("Sum = {0:0.00000}", sum);
        }
    }
}
