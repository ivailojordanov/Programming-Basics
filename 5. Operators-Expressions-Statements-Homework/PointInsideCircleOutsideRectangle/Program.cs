using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleOutsideRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X coordinate: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            double y = double.Parse(Console.ReadLine());
            bool isInCirle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(1.5, 2);
            bool isInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
            if (isInCirle && !isInRectangle)
            {
                Console.WriteLine("The point with coordinates ({0}, {1}) is inside a circle & outside of a rectangle", x, y);
            }
            else
            {
                Console.WriteLine("The point with coordinate ({0}, {1}) is not inside a circle & outside of a rectangle", x, y);
            }
        }
    }
}
