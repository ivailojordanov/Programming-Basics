using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("{0} ", a);
                    if (b > c) { Console.WriteLine("{0} {1}", b, c); }
                    else { Console.WriteLine("{0} {1}", c, b); }
                }
                else { Console.WriteLine("{0} {1} {2}", c, a, b); }
            }
            else 
            {
                if (a < c)
                {
                    if (b > c) { Console.Write("{0} {1}", b, c); }
                    else { Console.Write("{0} {1}", c, b); }
                    Console.WriteLine(" {0}", a);
                }
                else { Console.WriteLine("{0} {1} {2}", b, a, c); }
            }
        }
    }
}
