using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintAsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASCII");
            for (byte i = 0; i < 255; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
