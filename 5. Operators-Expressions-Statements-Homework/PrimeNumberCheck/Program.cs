using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number( lesser or equal to 100 ):  ");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (n <= 0 || n >= 100)
            {
                isPrime = false;
                Console.WriteLine("Invalid value!\nPlease try again.");
            }
            else if (n == 1)
            {
                isPrime = false;
                Console.WriteLine("The number is prime: {0}", isPrime);
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        Console.WriteLine("The number is prime: {0}", isPrime);
                        return;
                    }
                }
                isPrime = true;
                Console.WriteLine("The number is prime: {0}", isPrime);
            }
        }
    }
}
