using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter trapezoid a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter trapezoid b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter trapezoid h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid with a: {0} and b: {1}\nArea: {2}", a, b, ((a + b)/2) * h);
        }
    }
}
