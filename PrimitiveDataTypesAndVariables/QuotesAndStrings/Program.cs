using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuotesAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string trouble = "The use of quotations";
            string moretrouble = "causes difficulties.";

            string headache = trouble + " " + moretrouble;
            Console.WriteLine(headache);

            string quotes = "The \"use\" of quotations";
            string end = "causes difficulties.";

            string quotation = quotes + " " + end;
            Console.WriteLine(quotation);
        }
    }
}
