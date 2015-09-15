using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            double temp = 0;
            if (a > b) { temp = a; a = b; b = temp; Console.WriteLine("Result:{0} {1} ", a, b); }
            else { Console.WriteLine("Result:{0} {1} ", a, b); }
        }
    }
}
