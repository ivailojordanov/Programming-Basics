using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeTheNumbers1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            bool[] printed = new bool[n + 1];
            Random rnd = new Random();
            int numberToPrint = 0;
            for (int i = 1; i <= n; i++)
            {
                numberToPrint = rnd.Next(1, n + 1);
                if (!printed[numberToPrint])
                {
                    Console.Write("{0} ", numberToPrint);
                    printed[numberToPrint] = true;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();
        }
    }
}