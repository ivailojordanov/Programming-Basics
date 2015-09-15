using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            bool inRange = n < 100 && n > 1;

            if (inRange)
            {
                double nPlusOne = n + 1;
                double fact2N = 1;
                double factN = 1;
                double factN1 = 1;
                for (int i = 1; i <= 2 * n; i++)
                {
                    fact2N *= i;
                    if (i <= n)
                    {
                        factN *= i;
                    }
                    if (i <= n + 1)
                    {
                        factN1 *= i;
                    }
                }
                Console.WriteLine("2n!/(n+1)!n! = {0}", fact2N / (factN1 * factN));
            }
            else
            {
                Console.WriteLine("Invalid input. Correct input --> 1 < n < 100");
            }
        }
    }
}
