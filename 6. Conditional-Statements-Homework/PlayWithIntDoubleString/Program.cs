using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithIntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: \n1 --> int\n2 --> double\n3 --> string");
            int number = int.Parse(Console.ReadLine());

            int a = 0;
            double b = 0;
            string c = "";

            switch (number)
            {
                case 1: Console.WriteLine("Please enter a int: "); a = int.Parse(Console.ReadLine()); Console.WriteLine("{0}", a += 1); break;
                case 2: Console.WriteLine("Please enter a double: "); b = double.Parse(Console.ReadLine()); Console.WriteLine("{0}", b += 1); break;
                case 3: Console.WriteLine("Please enter a string: "); c = Console.ReadLine(); Console.WriteLine("{0}", c + "*"); break;
            }
        }
    }
}
