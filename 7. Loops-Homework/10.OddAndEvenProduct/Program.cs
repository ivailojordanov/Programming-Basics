using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            string n = Console.ReadLine();
            string[] splitedNumbers = n.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 0; i < splitedNumbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= int.Parse(splitedNumbers[i]);
                }
                else
                {
                    evenProduct *= int.Parse(splitedNumbers[i]);
                }
            }
            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + evenProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = " + oddProduct);
                Console.WriteLine("even_product = " + evenProduct);
            }
        }
    }
}
