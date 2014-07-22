using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            bool dividenumber = (a % 7 == 0) && (a % 5 == 0);
            Console.WriteLine(dividenumber);
        }
    }
}
