using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            long number = long.Parse(Console.ReadLine());
            bool inRange = number >= 2;

            if (inRange)
            {
                Console.WriteLine("Is the number prime? = {0}", Prime(number));
            }
            else
            {
                if (number == 0 || number == 1)
                {
                    Console.WriteLine("Is the number prime? = {0}", false);
                }
                else 
                { 
                    Console.WriteLine("Invalid input. Correct input --> n >= 0"); 
                }
            }
        }

        static bool Prime(long n)
        {
            int i = 0;
            bool isPrime = false;
            for (i = 1; i <= (int)Math.Sqrt(n); i++)
            {
                if (((i != 1 && i != n) && n % i == 0))
                {
                    isPrime = false;
                    break;
                }
            }
            if (i > (int)Math.Sqrt(n))
            {
                isPrime = true;
            }
            return isPrime;
        }
    }
}
