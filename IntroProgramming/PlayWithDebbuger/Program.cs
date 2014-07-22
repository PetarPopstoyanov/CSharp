using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayWithDebbuger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x :");
            int x = int.Parse(Console.ReadLine());
            for (int i=1; i<1000; i++)
            {
                Console.WriteLine(x=x+1);
            }
        }
           
    }
}
