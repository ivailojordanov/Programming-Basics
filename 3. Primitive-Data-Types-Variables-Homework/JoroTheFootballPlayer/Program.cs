using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoroTheFootballPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            int holidaysCount = int.Parse(Console.ReadLine());
            int weekendsHomeCount = int.Parse(Console.ReadLine());

            int weekendsInYear = 52;
            int normalWeekendsCount = weekendsInYear - weekendsHomeCount;
            double gamesCount = normalWeekendsCount * 2d / 3d + weekendsHomeCount * 1d + holidaysCount / 2d;
            if (leap == "t") { gamesCount = gamesCount + 3; }
            Console.WriteLine((int)gamesCount);
        }
    }
}
