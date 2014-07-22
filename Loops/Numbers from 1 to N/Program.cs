using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers_from_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < a + 1; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
