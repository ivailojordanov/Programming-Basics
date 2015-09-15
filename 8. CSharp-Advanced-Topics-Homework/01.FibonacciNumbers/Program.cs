using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            bool inRange = number >= 0;

            if (inRange)
            {
                Console.WriteLine("N-th Fibonacci number = {0}", Fib(number));
            }
            else
            {
                Console.WriteLine("Invalid input. Correct input --> n >= 0");
            }
        }

        static long Fib(int n)
        {
            long a = -1;
            long b = 1;
            long fib = 0;
            for (long i = 0; i < n + 2; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
            }
            return fib;
        }
    }
}
