using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            int hollidaysCount = int.Parse(Console.ReadLine());
            int weekendsHomeCount = int.Parse(Console.ReadLine());

            int weekendsInYear = 48;
            int normalWeekendsCount = weekendsInYear - weekendsHomeCount;
            double gamesCount =
                normalWeekendsCount * 3.0 / 4.0 +
                weekendsHomeCount * 1.0 +
                hollidaysCount * 2.0 / 3.0;
            if (leap == "leap")
            {
                gamesCount = gamesCount * 1.15;
            }
            Console.WriteLine((int)gamesCount);
        }
    }
}
