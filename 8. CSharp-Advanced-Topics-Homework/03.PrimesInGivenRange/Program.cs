using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive starting number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Enter a positive ending number: ");
            int endNum = int.Parse(Console.ReadLine());
            bool inRange = startNum < endNum && startNum >=0 && endNum > 0;

            if (inRange)
            {
                PrintList(FindPrimesInRange(startNum, endNum));
            }
            else
            {
                Console.WriteLine("Invalid input. Correct input --> startNum < endNum && startNum >= 0 && endNum > 0"); 
            }
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> numbers = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = i > 1 ? true : false;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }

        static void PrintList<T>(IEnumerable<T> primes)
        {
            if (primes.Any())
            {
                Console.WriteLine("Output:\n" + string.Join(", ", primes));
            }
            else
            {
                Console.WriteLine("(empty list)");
            }
        }

    }
}
