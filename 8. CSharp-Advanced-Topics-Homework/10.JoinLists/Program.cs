using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first list of numbers on a line, separated by a space:");
            List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine("Enter second list of numbers on a line, separated by a space:");
            List<string> secondList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            firstList.InsertRange(0, secondList);
            firstList.Sort();
            Int32 index = 0;
            while (index < firstList.Count - 1)
            {
                if (firstList[index] == firstList[index + 1])
                    firstList.RemoveAt(index);
                else
                    index++;
            }

            Console.WriteLine("Output:\n" + string.Join(" ", firstList));
        }
    }
}
