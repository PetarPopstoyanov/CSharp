using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            int p1 = 3;
            int p2 = 24;

            for (int i = 0; i < 3; i++)
            {
                long v1 = (n & (1 << p1)) >> p1;
                long v2 = (n & (1 << p2)) >> p2;
 
                if (v1 == 0)
                {
                    n = n & (~(1 << p2));
                }
                else if (v1 == 1)
                {
                    n = n | (1 << p2);
                }

                if (v2 == 0)
                {
                    n = n & (~(1 << p1));
                }
                else if (v2 == 1)
                {
                    n = n | (1 << p1);
                }

                p1++;
                p2++;
            }

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine(n);
        }
    }
}
