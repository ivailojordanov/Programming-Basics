using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitAtPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Value of bit [0 or 1]: ");
            int bitValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: {0}", number);
            Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
            if (bitValue == 0)
            {
                number = (number & ~(1 << index));
            }
            else
            {
                number = number | (1 << index);
            }
            Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("Number: {0}", number);
        }
    }
}
