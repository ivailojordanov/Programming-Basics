using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinaryNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Decimal number: ");
            long dec = long.Parse(Console.ReadLine());
            long rest = 0;
            string binary = string.Empty;
            Console.WriteLine("Decimal: {0}", dec);
            while (dec > 0)
            {
                rest = dec % 2;
                dec /= 2;
                binary = rest.ToString() + binary;
            }
            Console.WriteLine("Binary: {0}", binary);
        }
    }
}