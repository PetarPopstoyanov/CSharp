using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5.3f;
            float b = 6.01f;
            Boolean compare = (a == b);
            Console.WriteLine(compare);
            float c = 5.00000001f;
            float d = 5.00000003f;
            Console.WriteLine(c == d);
        }
    }
}
