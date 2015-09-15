using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ExtractURLFromText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            Console.WriteLine("Enter text:");
            List<string> text = new List<string>(Console.ReadLine().Split(new char[] { ' ', ',', ';', '!', '"', }, StringSplitOptions.RemoveEmptyEntries));
            List<string> words = new List<string> { "http://", "www." };
            text = text.Where(s => words.Any(w => s.Contains(w))).Distinct().ToList();

            if (text.Count == 0)
            {
                Console.WriteLine("\nno URLs in the text");
                return;
            }

            Console.WriteLine("\nURLs in the text (no duplicates): ");
            foreach (string url in text)
            {
                Console.WriteLine(url.TrimEnd(new char[] { '.' }));
            }
        }
    }
}
