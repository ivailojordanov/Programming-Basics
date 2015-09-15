using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for(int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                sum1 = sum1 + element;
            }
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                sum2 = sum2 + element;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum= " + sum1);
            }
            else
            {
                double diff = Math.Abs(sum1 - sum2);
                Console.WriteLine("No, diff=" + diff);
            }
        }
    }
}
