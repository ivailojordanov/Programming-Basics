using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                str = str.Replace(",", ".");
                sum += double.Parse(str);
            }
            Console.WriteLine("Sum of all elements is: {0}", sum);
        }
    }
}
