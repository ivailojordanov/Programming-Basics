using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                uint bit = (number >> index) & 1;
                Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
                Console.WriteLine("Bit at index is: {0}", bit);
            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
        }
    }
}
