using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool ThirdDigit = (number / 100) % 10 == 7;
            Console.WriteLine("Is it third digit from right- to- left is 7? --->> {0}", ThirdDigit);
        }
    }
}
