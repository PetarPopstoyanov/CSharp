using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int a = int.Parse(Console.ReadLine());

            if (a > 1 && a < 20)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = i + 1; j <= a + i ; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
