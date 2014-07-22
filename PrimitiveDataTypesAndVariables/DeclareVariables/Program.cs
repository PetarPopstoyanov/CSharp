using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeclareVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int apples = 52130;    
            sbyte points = -115;    
            uint strawberries = 4825932;     
            byte watermelons = 97; 
            short years = -10000;
            Console.WriteLine(
                "{0} apples or {1} points, or {2} strawberries, or {3} watermellons, or {4} years.",
                apples, points, strawberries, watermelons, years);
        }
    }
}
