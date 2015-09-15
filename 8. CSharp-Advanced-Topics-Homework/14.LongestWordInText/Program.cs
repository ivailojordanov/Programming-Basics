using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestWordInText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            Console.WriteLine("Enter text:");
            List<string> text = new List<string>(Console.ReadLine().Split(new char[] { ' ', ',', ':', ';', '.', '!', '"', '\'' }, StringSplitOptions.RemoveEmptyEntries));
            List<string> longest = text.Distinct().OrderByDescending(c => c.Length).ThenBy(c => c).ToList();

            Console.WriteLine("Longest word/s:");
            foreach (string word in longest)
            {
                if (word.Length == longest.First().Length)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
