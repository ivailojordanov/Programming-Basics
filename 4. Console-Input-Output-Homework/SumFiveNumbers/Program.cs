using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers separated by space: ");
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);
            double d = double.Parse(s[3]);
            double e = double.Parse(s[4]);
            Console.WriteLine("Numbers: {0} {1} {2} {3} {4} \nSum: {5}", a, b, c, d, e, (a + b + c + d + e));
        }
    }
}
