using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of names on a line, separated by a space:");
            List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine("Enter names to remove on a line, separated by a space:");
            List<string> secondList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            for (int i = 0; i < secondList.Count; i++)
            {
                firstList.RemoveAll(item => item == secondList[i]);
            }

            Console.WriteLine("Output:\n" + string.Join(" ", firstList));
        }
    }
}
