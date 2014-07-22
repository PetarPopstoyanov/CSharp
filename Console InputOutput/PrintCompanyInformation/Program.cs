using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company name:");
            string name = Console.ReadLine();
            Console.Write("Company adress:");
            string adress = Console.ReadLine();
            Console.Write("Phone number:");
            string number = Console.ReadLine();
            Console.Write("Fax number:");
            string fax = Console.ReadLine();
            Console.Write("Web sait:");
            string web = Console.ReadLine();
            Console.Write("Manager firts name:");
            string mfn = Console.ReadLine();
            Console.Write("Manager last name:");
            string mln = Console.ReadLine();
            Console.Write("Manager Age:");
            byte mage = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone:");
            string mnum = Console.ReadLine();

            Console.WriteLine("Company name: {0}\nCompany adress: {1}\nPhone number: {2}\nFAX number: {3}\nWeb Sait: {4}\nManager: {5} {6} (Age: {7}, Tel: {8})", name,
                adress, number, fax, web, mfn, mln, mage, mnum);
            
        }
    }
}
