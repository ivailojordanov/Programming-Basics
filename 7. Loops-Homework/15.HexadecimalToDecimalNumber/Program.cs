using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Hexadecimal number: ");
            string n = Console.ReadLine();
            long dec = 0;

            for (int i = 0; i < n.Length; i++)
            {
                switch (n[i])
                {
                    case 'A': dec += 10 * (long)Math.Pow(16, n.Length - i - 1); break;
                    case 'B': dec += 11 * (long)Math.Pow(16, n.Length - i - 1); break;
                    case 'C': dec += 12 * (long)Math.Pow(16, n.Length - i - 1); break;
                    case 'D': dec += 13 * (long)Math.Pow(16, n.Length - i - 1); break;
                    case 'E': dec += 14 * (long)Math.Pow(16, n.Length - i - 1); break;
                    case 'F': dec += 15 * (long)Math.Pow(16, n.Length - i - 1); break;
                    default: dec += (long)char.GetNumericValue(n[i]) * (long)Math.Pow(16, n.Length - i - 1); break;
                }
            }

            Console.WriteLine(dec);
        }
    }
}
