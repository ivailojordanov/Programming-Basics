using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter rectangle width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Please enter rectangle height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle with width {0} and height {1}:\nPerimeter: {2}\nArea: {3}", width, height, 2 * (width + height), width * height);
        }
    }
}
