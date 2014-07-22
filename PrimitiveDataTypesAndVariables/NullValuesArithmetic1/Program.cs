using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a + 5);
            Console.WriteLine(b + 10);
            Console.WriteLine(5 + a.GetValueOrDefault());
            Console.WriteLine(20 + b.GetValueOrDefault());
        }
    }
}
