using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year you were born in :");
            int YearOfBirth = int.Parse(Console.ReadLine());
            DateTime currentYear = DateTime.Now;
            DateTime futureYear = currentYear.AddYears(10);
            Console.WriteLine("After 10 years you will be " + (futureYear.Year - YearOfBirth) + " years old!");
        }
    }
}
