using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extract_Bit_from_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine());
            int nRightp = n >> p;
            int bit = nRightp & 1;
            Console.WriteLine(bit);
        }
    }
}
