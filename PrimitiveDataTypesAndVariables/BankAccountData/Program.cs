using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name:");
            string firstName = Console.ReadLine();
            Console.Write("Middle name:");
            string middleName = Console.ReadLine();
            Console.Write("Family name:");
            string familyName = Console.ReadLine();

            Console.WriteLine("\nFirst name: {0}\nMiddle name: {1}\nFamily name: {2},", firstName, middleName, familyName);
            string bankname = "FirstInvBank.";
            Console.WriteLine("Welcome to your online bank account in {0}", bankname);
            decimal balance = 1500;
            Console.WriteLine("You're balance is {0}$", balance);
            string IBAN = "BG90FIN4523VFHU";
            Console.WriteLine("You're IBAN of the account is {0}", IBAN);
            ulong credcard1 = 423123544256521;
            ulong credcard2 = 123454684568123;
            ulong credcard3 = 456824354598789;
            Console.WriteLine("Yo have three credit cards. The numbers of them are:\n{0}\n{1}\n{2}", credcard1, credcard2, credcard3);

        }
    }
}
