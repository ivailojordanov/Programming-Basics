using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Binary number: ");
            string n = Console.ReadLine();
            string[] binaryNumber = n.Select(c => c.ToString()).ToArray();
            double result = 0;
            int j = 0;
            for (int i = binaryNumber.Length - 1; i >= 0; --i)
            {
                if (binaryNumber[i] == "1")
                {
                    result += Math.Pow(2, j);
                }
                j++;
            }
            Console.WriteLine("Binary: {0}\nDecimal: {1}", n, result);
        }
    }
}