using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Decimal number: ");
            long n = long.Parse(Console.ReadLine());
            string hex = "";
            do
            {
                switch (n % 16)
                {
                    case 10: hex = "A" + hex; break;
                    case 11: hex = "B" + hex; break;
                    case 12: hex = "C" + hex; break;
                    case 13: hex = "D" + hex; break;
                    case 14: hex = "E" + hex; break;
                    case 15: hex = "F" + hex; break;
                    default: hex = n % 16 + hex; break;
                }
                n = n / 16;
            } while (n > 0);
            Console.WriteLine(hex);
        }
    }
}
