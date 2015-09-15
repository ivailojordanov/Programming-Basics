using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter Quadratic Equation coefficients: ");
            Console.Write("a = ");
            string QA = Console.ReadLine();
            QA = QA.Replace(",", ".");
            double a = double.Parse(QA);
            Console.Write("b = ");
            string QB = Console.ReadLine();
            QB = QB.Replace(",", ".");
            double b = double.Parse(QB);
            Console.Write("c = ");
            string QC = Console.ReadLine();
            QC = QC.Replace(",", ".");
            double c = double.Parse(QC);

            double D = Math.Pow(b, 2) - (4 * a * c);
            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Two real roots: \nx1 = {0}; x2 = {1}", x1, x2);
            }
            else if (D == 0)
            {
                double x1x2 = -b / (2 * a);
                Console.WriteLine("One real root: \nx1 = x2 = {0}", x1x2);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
