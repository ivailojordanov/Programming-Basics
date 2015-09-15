using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool inCircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(2, 2);
            Console.WriteLine("Are points {0} and {1} in circle with coordinates 0,0 and radius 2: {2}", x, y, inCircle);
        }
    }
}
