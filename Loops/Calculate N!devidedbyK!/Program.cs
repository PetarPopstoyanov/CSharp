using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate_N_devidedbyK_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n! = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter k! = ");
            int k = int.Parse(Console.ReadLine());

            int factN = 1;
            int factK = 1;
            int result = 0;

            if (n > 1 && k > 1 && n < 100 && k < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    factN = i * factN;
                }
                for (int j = 1; j <= k; j++)
                {
                    factK = j * factK;
                }
                result = factN / factK;
                Console.WriteLine(result);
            }
            
        }
    }
}
