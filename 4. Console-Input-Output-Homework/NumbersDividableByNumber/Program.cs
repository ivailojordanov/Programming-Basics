using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersDividableByNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
                Console.WriteLine("Enter two positive numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0 || a > b) { Console.WriteLine("The number must be positive and (first < second)! "); goto label; }
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) { count++; }
            }
            Console.WriteLine("Number of dividable numbers in the interval: {0}", count);
        }
    }
}
