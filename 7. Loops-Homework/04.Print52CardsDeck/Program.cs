using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Print52CardsDeck
{
    class Program
    {
        static void Main(string[] args)
        {

            /*String[] colors = new String[] { "♣", "♦", "♥", "♠" };
            String[] cards = new String[] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            List<string> deck = new List<string>();
            for (int i = 0; i < cards.Length; i++){
                for (int j = 0; j < colors.Length; j++){
                    deck.Add(cards[i] + colors[j]);
                }
            }
            foreach (string card in deck)
            {
                Console.WriteLine(card.ToString() + " ");
            }*/

            char[] colors = { '♠', '♣', '♦', '♥' };
            char? currentChar = null;

            for (int card = 2; card <= 15; card++)
            {
                for (int colorIndex = 0; colorIndex < 4; colorIndex++)
                {
                    currentChar = colors[colorIndex];
                    switch (card)
                    {
                        case 11:
                            break;
                        case 12:
                            Console.Write("J{0} ", currentChar);
                            break;
                        case 13:
                            Console.Write("D{0} ", currentChar);
                            break;
                        case 14:
                            Console.Write("K{0} ", currentChar);
                            break;
                        case 15:
                            Console.Write("A{0} ", currentChar);
                            break;
                        default:
                            Console.Write("{0}{1} ", card, currentChar);
                            break;
                    }

                }
                if (card != 11)
                {
                    Console.WriteLine();
                }
            }
            
        }
    }
}
