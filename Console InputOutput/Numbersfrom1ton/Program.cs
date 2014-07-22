using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbersfrom1ton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
