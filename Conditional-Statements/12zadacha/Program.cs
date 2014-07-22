using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zero_Subset
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            bool found = false;
            int[] number = new int[5];
            //reading input
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\nEnter a value for number " + (i + 1) + " : ");
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            //creating the sums
            for (int onStart = 0; onStart < 5; onStart++)
            {
                sum = 0; //seting every time sum to 0, befor starting to calculate the next sum of numbers
                for (int onEnd = onStart; onEnd < 5; onEnd++)
                {
                    //suming
                    sum = sum + number[onEnd];
                    if (sum == 0)
                    {
                        found = true;
                        //printig the zero subset 
                        Console.WriteLine();
                        for (int i = onStart; i < onEnd; i++)
                        {
                            Console.Write("{0} + ", number[i]);
                        }
                        Console.Write(number[onEnd]);
                        Console.Write(" = 0\n\n");
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine();
                Console.WriteLine("no zero subset\n\n");
            }
        }
    }
}
