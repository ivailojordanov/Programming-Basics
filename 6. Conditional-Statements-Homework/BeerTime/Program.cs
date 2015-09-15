using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeBeer = new DateTime();
            Console.Write("Enter time: ");
            bool isValid = DateTime.TryParse(Console.ReadLine(), out timeBeer);
            if (isValid)
            {
                Console.WriteLine(timeBeer.ToShortTimeString());
                TimeSpan daytime = timeBeer.TimeOfDay;
                TimeSpan endBeertime = new TimeSpan(3, 00, 00);
                TimeSpan startBeertime = new TimeSpan(13, 00, 00);

                if ((daytime < endBeertime) || (daytime >= startBeertime))
                {
                    Console.WriteLine("Beer time");
                }
                else
                {
                    Console.WriteLine("Non-beer time");
                }
            }
            else
            {
                Console.WriteLine("Invalid time");
            }
        }
    }
}
