using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int a = int.Parse(Console.ReadLine());
            if (a == 1 || a == 2 || a == 3)
            {
                int result = a * 10;
                Console.WriteLine(result);
            }
            else if (a == 4 || a == 5 || a == 6)
            {
                int result1 = a * 100;
                Console.WriteLine(result1);
            }
            else if (a == 7 || a == 8 || a == 9)
            {
                int result2 = a * 1000;
                Console.WriteLine(result2);
            }
            else if (a == 0 || a > 9)
            {
                Console.WriteLine("Invalid Score");
            }
        }
    }
}
