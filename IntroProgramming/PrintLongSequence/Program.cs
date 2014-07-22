using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y :");
            int y = int.Parse(Console.ReadLine());
            for (int i=0; i<500; i++)
            {
                Console.WriteLine(x=x+2);
                Console.WriteLine(y=y-2);
            }
        }
    }
}
