using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CirclePerimeterArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter circle radius: ");
            string radiusString = Console.ReadLine();
            radiusString = radiusString.Replace(",", ".");
            double radius = double.Parse(radiusString);
            double area = Math.Pow(radius,2) * Math.PI;
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Circle radius: {0:0.00} \nCircle area: {1:0.00} \nCircle perimeter: {2:0.00} ", radius, area, perimeter);
        }
    }
}
