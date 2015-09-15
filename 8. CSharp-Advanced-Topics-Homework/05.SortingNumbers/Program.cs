using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            bool inRange = n > 1;

            if (inRange)
            {
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                Array.Sort(array);
                Console.WriteLine();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            else
            {
                Console.WriteLine("Enter a number greater than 1.");
            }
        }
    }
}
