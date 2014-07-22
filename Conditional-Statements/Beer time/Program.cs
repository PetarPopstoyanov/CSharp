using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beer_time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time:");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dt.ToString("hh:mm tt"));
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            if (dt > startTime || dt < endTime)
            {
                Console.WriteLine("Beer time");
            }
            else
                Console.WriteLine("Non beer time");
        }
    }
}
