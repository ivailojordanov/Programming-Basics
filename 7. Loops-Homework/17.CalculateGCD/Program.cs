using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CalculateGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            int result = 0;
            int t = 0;
            while (b != 0){
                t = b;
                b = a % b;
                a = t;
                result = a;
            }
            Console.WriteLine("GCD(a,b) = {0}", result);
        }
    }
}
