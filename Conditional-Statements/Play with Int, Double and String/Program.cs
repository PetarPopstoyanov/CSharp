using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Play_with_Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1-->int");
            Console.WriteLine("2-->double");
            Console.WriteLine("3-->string");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Please enter an integer:");
                    int a = int.Parse(Console.ReadLine());
                    int result = a + 1;
                    Console.WriteLine(result); break;
                case 2:
                    Console.WriteLine("Please enetr a double:");
                    double b = double.Parse(Console.ReadLine());
                    double result1 = b + 1;
                    Console.WriteLine(result1); break;
                case 3:
                    Console.WriteLine("Please enter a string:");
                    string sign = Console.ReadLine();
                    Console.WriteLine(sign + "*"); break;
            }
        }
    }
}
