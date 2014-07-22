using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = a + b;
            b = a - b;
            a = a - b;
          
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
