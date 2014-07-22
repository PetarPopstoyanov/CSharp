using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name:");
            string firstName = Console.ReadLine();
            Console.Write("Family name:");
            string familyName = Console.ReadLine();
            Console.Write("Age:");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Gender (f or m):");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Enter your ID number:");
            ulong IDnumber = ulong.Parse (Console.ReadLine());
            Console.Write("Enter employee number (from 27560000 to 27569999):");
            int Empnumber = int.Parse (Console.ReadLine());
            Console.WriteLine("First name: {0}\nFamyli name: {1}\nAge: {2}\nIDnumber: {3}\nEmpnumber: {4}", firstName, familyName, age, IDnumber, Empnumber);
            if (gender == 'm')
                {
            Console.WriteLine("Gender: Male");
                }
            else if (gender == 'f')
                    {
                        Console.WriteLine("Gender: Female");
                    }
        }
    }
}
