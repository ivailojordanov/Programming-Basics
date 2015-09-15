using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateFormula
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
                int factN = 1;
                int factK = 1;
                for (int i = 1; i <= n; i++)
                {
                    factN *= i;
                    if (i <= k)
                    {
                        factK *=  i;
                    }
                }
                Console.WriteLine("n!/k! = {0}", factN / factK);
            }
            else
            {
                Console.WriteLine("Invalid input. Correct input --> 1 < k < n < 100");
            }
        }
    }
}
