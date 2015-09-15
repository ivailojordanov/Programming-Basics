using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.TrailingZeroesInN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int zeroCount = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            string factorialString = factorial.ToString();
            for (int i = factorialString.Length - 1; i >= 0; i--)
            {
                if (factorialString[i] == '0')
                {
                    zeroCount++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Factorial: {0}\nTrailing zeroes of n!: {1}", factorial, zeroCount);
        }
    }
}
