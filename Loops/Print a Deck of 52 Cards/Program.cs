using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Print_a_Deck_of_52_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = "2";
            for (int i = 2; i <=14; i++)
            {
                if (i <= 10)
                {
                    Console.Write(i);
                    card = Convert.ToString(i);
                }
                else if (i == 11)
                {
                    card = "J";
                    Console.Write(card);
                }
                else if (i == 12)
                {
                    card = "Q";
                Console.Write(card);
                }
                else if (i == 13)
                {
                    card = "K";
                Console.Write(card);
                }
                else if (i == 14)
                {
                    card = "A";
                    Console.Write(card);
                }
                for (int suit = 1; suit <= 4; suit++)
                {
                    switch (suit)
                    {
                        case 1:
                            char symbol1 = '\u0005';
                            Console.Write(symbol1 + " " + card);
                            break;
                        case 2:
                            char symbol2 = '\u0004';
                            Console.Write(symbol2 + " " + card);
                            break;
                        case 3:
                            char symbol3 = '\u0003';
                            Console.Write(symbol3 + " " + card);
                            break;
                        case 4:
                            char symbol4 = '\u0006';
                            Console.WriteLine(symbol4 + " ");
                            break;
                    }
                }
            }
        }
    }
}