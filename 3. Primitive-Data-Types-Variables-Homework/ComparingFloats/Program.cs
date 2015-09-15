using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of number A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter value of number B: ");
            double b = double.Parse(Console.ReadLine());

            double expression = Math.Abs(a - b);
            bool equal = expression < 0.000001;

            if (equal == true)
            {
                Console.WriteLine("The difference  {0} < 0.000001\nEqual: {1}", expression, equal);
            }
            else
            {
                Console.WriteLine("The difference {0} > 0.000001\nEqual: {1}", expression, equal);
            }
        }
    }
}
