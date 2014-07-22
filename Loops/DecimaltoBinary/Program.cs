using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimaltoBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            long dec = long.Parse(Console.ReadLine());

            string binary = string.Empty;
            long rest;

            while (dec>0)
            {
                rest = dec % 2;
                dec = dec / 2;
                binary = rest.ToString() + binary;
            }
            Console.WriteLine(binary);
        }
    }
}
