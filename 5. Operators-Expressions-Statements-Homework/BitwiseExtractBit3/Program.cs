using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());
            if (number >= 0)
            {
                uint bit = (number >> 3) & 1;
                Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
                Console.WriteLine("Bit #3 is: {0}", bit);
            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
        }
    }
}
