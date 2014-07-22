using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check is it odd?:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                {
                    Console.WriteLine("False");
                }
                    else
                        {
                            Console.WriteLine("True");
                        }   
        }
    }
}
