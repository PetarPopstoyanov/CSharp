using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers_Not_Divisible_by_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
                int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < a + 1; i++)
			{
                if (i % 3 == 0 || i % 7 == 0)
                    continue;
			 Console.Write(i + " ");
			}
        }
    }
}
