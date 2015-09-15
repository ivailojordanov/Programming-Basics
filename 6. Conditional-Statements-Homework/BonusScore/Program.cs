using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Score: ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 1 && score <= 3) { score = score * 10; Console.WriteLine("Score: {0}", score); }
            else if (score >= 4 && score <= 6) { score = score * 100; Console.WriteLine("Score: {0}", score); }
            else if (score >= 7 && score <= 9) { score = score * 1000; Console.WriteLine("Score: {0}", score); }
            else Console.WriteLine("Invalid Score");
        }
    }
}
