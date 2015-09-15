using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            label:
                Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Enter positive number!"); goto label; }
            long a = -1;
            long b = 1;
            long fib = 0;
            for (long i = 0; i < n; i++)
            {
                fib = a + b;
                Console.Write("{0} ", fib);
                a = b;
                b = fib;
            }
        }
    }
}
