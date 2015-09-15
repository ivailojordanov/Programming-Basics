using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            double S = 1;
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                S += fact / Math.Pow(x, i);
            }
            Console.WriteLine("1 + 1!/x + 2!/x2 + … + n!/xn = {0:0.00000}", S);
        }
    }
}
