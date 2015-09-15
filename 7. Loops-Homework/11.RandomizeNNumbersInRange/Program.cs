using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNNumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max: ");
            int max = int.Parse(Console.ReadLine());
            bool inRange = min <= max;

            if (inRange)
            {
                Random rnd = new Random();
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", rnd.Next(min, max + 1));
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Correct input --> min <= max");
            }
        }
    }
}