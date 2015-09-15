using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isODD = number % 2 != 0;
            Console.WriteLine("Is Odd? - {0}", isODD);
        }
    }
}
