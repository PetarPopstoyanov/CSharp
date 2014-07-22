using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModifyABitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter bit (0 or 1): ");
            int v = int.Parse(Console.ReadLine());

            if (v == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask; 
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
                Console.WriteLine(result);
            }
            else if (v == 1)
            {
                int mask1 = 1 << p;
                int result1 = n | mask1;
                Console.WriteLine(Convert.ToString(result1, 2).PadLeft(16, '0'));
                Console.WriteLine(result1);
            }
            if (v == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
                Console.WriteLine(result);
            }
            else if (v == 1)
            {
                int mask1 = 1 << p;
                int result1 = n | mask1;
                Console.WriteLine(Convert.ToString(result1, 2).PadLeft(16, '0'));
                Console.WriteLine(result1);
            }
            if (v == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
                Console.WriteLine(result);
            }
            else if (v == 1)
            {
                int mask1 = 1 << p;
                int result1 = n | mask1;
                Console.WriteLine(Convert.ToString(result1, 2).PadLeft(16, '0'));
                Console.WriteLine(result1);
            }
        }
    }
}
