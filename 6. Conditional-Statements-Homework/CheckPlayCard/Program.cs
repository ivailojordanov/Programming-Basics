using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards = new string[]{ "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            Console.Write("Enter a card: ");
            string enteredCard = Console.ReadLine();

            if (Array.IndexOf(cards, enteredCard) >= 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
