using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool Div = number % 7 == 0 && number % 5 ==0 && number != 0;
            Console.WriteLine("Is {0} divisible(without remainder) by 5 and 7 at the same time:  {1}", number, Div);
        }
    }
}
