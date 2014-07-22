using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate_N_devided_K__N_K___
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n! = ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.Write("Enter k! = ");
            ulong k = ulong.Parse(Console.ReadLine());

            ulong factN = 1;
            ulong factK = 1;
            ulong factNandK = 1;
            ulong result = 0; 

            if (n > 1 && k > 1 && n < 100 && k < 100)
            {
                for (ulong i = 1; i <= n; i++)
                {
                    factN = i * factN;
                }
                for (ulong j = 1; j <= k; j++)
                {
                    factK = j * factK;
                }
                for (ulong v = 1; v <= n - k; v++)
                {
                    factNandK = v * factNandK;
                }
                result = factN / (factK * factNandK);
                Console.WriteLine(result);
            }
        }
    }
}
