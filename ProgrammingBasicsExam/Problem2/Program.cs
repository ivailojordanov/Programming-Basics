using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string encryptedMessage = Console.ReadLine();

            int sumCode = 0;

            foreach (var character in secretWord)
            {
                sumCode += (int)character;
            }
            int sum = 0;
            sum = number(sumCode);
            
            string maskedMessage = string.Empty;
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char currentSymbol = encryptedMessage[i];

                if (encryptedMessage[i] % sum == 0)
                {
                    maskedMessage += (char)((int)currentSymbol + sum);
                }
                else
                {
                    maskedMessage += (char)((int)currentSymbol - sum);
                }
            }
            string reversedMessage = string.Empty;
            for (int i = maskedMessage.Length - 1; i >= 0; i--)
            {
                reversedMessage += maskedMessage[i];
            }
            Console.WriteLine(reversedMessage);
        }
        static int number(int input)
        {
            int result = input % 9;
            return (result == 0 && input > 0) ? 9 : result;
        }
    }
}
