using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumberComparerer
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter 2 numbers: ");
            string first = Console.ReadLine();
            first = first.Replace(",", ".");
            double a = double.Parse(first);
            string second = Console.ReadLine();
            second = second.Replace(",", ".");
            double b = double.Parse(second);

            Console.WriteLine("The greater number of {0} and {1} is {2}", a, b, Math.Max(a,b));
        }
    }
}
