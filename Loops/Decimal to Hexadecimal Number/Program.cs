﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decimal_to_Hexadecimal_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your decimal number: ");
            long dec = long.Parse(Console.ReadLine());

            string hexaStr = dec.ToString("X");

            long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

            Console.WriteLine(hexaStr);
        }
    }
}
