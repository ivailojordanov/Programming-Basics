using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(new string('-', 10));
            a = 5;
            b = 10.55;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
