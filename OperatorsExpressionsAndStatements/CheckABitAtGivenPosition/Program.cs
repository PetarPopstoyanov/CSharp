using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckABitAtGivenPosition
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
            bool bitpositionp = true;
            if (bit == 1)
            {
                Console.WriteLine(bitpositionp);
            }
            else
            {
                bitpositionp = false;
                Console.WriteLine(bitpositionp);
            }
        }
    }
}
