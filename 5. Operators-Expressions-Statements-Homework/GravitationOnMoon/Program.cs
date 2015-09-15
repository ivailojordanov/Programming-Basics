using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Weight on Earth - {0}\nWeight on Moon - {1}", weight, weight * 0.17);
        }
    }
}
