using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());

            Console.WriteLine("Number: {0}", number);
            Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
            uint mask = 7;
            uint firstBits = (number & (mask << 3)) >> 3;
            uint secondBits = (number & (mask << 24)) >> 24;
            number = number & ~(mask << 3);
            number = number & ~(mask << 24);
            number = number | (firstBits << 24);
            number = number | (secondBits << 3);
            Console.WriteLine("Number: {0}", number);
            Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
