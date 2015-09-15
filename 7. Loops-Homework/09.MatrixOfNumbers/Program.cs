using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            bool inRange = n <= 20 && n >= 1;

            if (inRange)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j < n + i; j++)
                    {
                        Console.Write("{0} ", j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Correct input --> 1 <= n <= 20");
            }
        }
    }
}
