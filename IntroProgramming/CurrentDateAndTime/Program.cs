using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrentDateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;             
            string format = "MMM ddd d HH:mm yyyy";   
            Console.WriteLine(time.ToString(format));
        }
    }
}
