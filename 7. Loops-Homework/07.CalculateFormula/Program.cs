using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int k = int.Parse(Console.ReadLine());
            bool inRange = n < 100 && k > 1 && n > k;

            if (inRange)
            {
                double factN = 1;
                double factK = 1;
                double factNK = 1;
                for (int i = 1; i <= n; i++)
                {
                    factN = factN * i;
                    if (i <= k)
                    {
                        factK = factK * i;
                    }
                }
                for(int i = 1; i <= n - k; i++)
                {
                    factNK = factNK * i;
                }
                Console.WriteLine("n!/(k!*(n-k)!) = {0}", factN / (factK * factNK));
            }
            else
            {
                Console.WriteLine("Invalid input. Correct input --> 1 < k < n < 100");
            }
        }
    }
}
