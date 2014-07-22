using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HexadecimaltoDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a hexdecimal number:");
            string hexa = Console.ReadLine();

            long dec = long.Parse(hexa, NumberStyles.HexNumber);
            Console.WriteLine(dec);
        }
    }
}
