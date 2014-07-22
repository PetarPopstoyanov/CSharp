using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string nice = "Hello";
            string place = "World";
            
            string earth = nice + " " + place;
            Console.WriteLine(earth);

            string great = "Beautiful";
            Console.WriteLine(nice + " " + great + " " + place);
        }
    }
}
