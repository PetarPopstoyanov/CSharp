﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_to_Decimal_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string binary = Console.ReadLine();

            long dec = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '0')
                {
                    continue;
                }

                dec += (long)Math.Pow(2, i);
            }

            Console.WriteLine(dec);
        }
    }
}
