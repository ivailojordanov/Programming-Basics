using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CountingWordInText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            Console.WriteLine("Enter a word (case-insensitive) to search in the text:");
            string match = Console.ReadLine().Trim();
            Console.WriteLine("\nEnter text:");
            string text = Console.ReadLine().ToLower();
            List<string> word = new List<string>(text.Split(new char[] { ' ', '.', ',', ';', '!', '"', '(', ')', '@', '/', '“', '”', '\\', '?' }, StringSplitOptions.RemoveEmptyEntries));
            word = word.Where(x => x.ToString().ToLower().Split(',').Where(a => a.Trim() == match.ToLower()).Any()).ToList();
            Console.WriteLine("\n\"{0}\" occurrences: {1}", match, word.Count);
        }
    }
}
