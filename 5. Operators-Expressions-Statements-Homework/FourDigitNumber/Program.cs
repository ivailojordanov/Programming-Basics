using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a four digit number: ");
            int number = int.Parse(Console.ReadLine());
            int a = number % 10;
            int b = (number / 10) % 10;
            int c = (number / 100) % 10;
            int d = (number / 1000) % 10;
            int sumOfDigits = a + b + c + d;
            Console.WriteLine("Digit: {0}\nSum of Digits: {1}\nReversed order: {2}{3}{4}{5}\nLast digit in front: {2}{5}{4}{3}\nSecond and third digits exchanged: {5}{3}{4}{2}", number, sumOfDigits, a, b, c, d);
        }
    }
}
