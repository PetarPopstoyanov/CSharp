using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int nRightp = n >> p;
            int bit = nRightp & 1;
            Console.WriteLine(bit);
        }
    }
}
