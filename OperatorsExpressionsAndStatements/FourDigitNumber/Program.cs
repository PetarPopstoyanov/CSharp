using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
           
            int fourthnumber = number % 10;

            int third = number / 10;
            int thirdnumber = third % 10;

            int second = number / 100;
            int secondnumber = second % 10;

            int first = number / 1000;
            int firstnumber = first % 10;
        
            int calculate = firstnumber + secondnumber + thirdnumber + fourthnumber;

            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("You have entered a number outside the range");
            }
            else if (firstnumber ==0)
            {
                Console.WriteLine("You have entered a number outside the range");
            }
            else
            {
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Sum of the digits: " +calculate);
            Console.WriteLine("Reverse order: {0}{1}{2}{3}", fourthnumber, thirdnumber, secondnumber, firstnumber);
            Console.WriteLine("Last digit get first: {0}{2}{1}{3}", fourthnumber, thirdnumber, secondnumber, firstnumber);
            Console.WriteLine("Reverse Second and Third digits: {3}{1}{2}{0}", fourthnumber, thirdnumber, secondnumber, firstnumber);
            }
        }
    }
}
