using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n! = ");
            ulong n = ulong.Parse(Console.ReadLine());
            
            ulong fact2N = 1;
            ulong factN = 1;
            ulong factNand1 = 1;
            ulong result = 0;

            if (n > 1 && n < 100)
            {
                for (ulong i = 1; i <= 2 * n; i++)
                {
                    fact2N = i * fact2N;
                }
                for (ulong j = 1; j <= n + 1; j++)
                {
                    factNand1 = j * factNand1;
                }
                for (ulong v = 1; v <= n; v++)
                {
                    factN = v * factN;
                }
                result = fact2N / (factNand1 * factN);
                Console.WriteLine(result);
            }
        }
    }
}
