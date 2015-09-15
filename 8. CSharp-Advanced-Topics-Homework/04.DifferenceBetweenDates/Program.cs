using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DifferenceBetweenDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first date in dd.MM.yyyy format: ");
            DateTime date1;
            bool startDateParse = DateTime.TryParse(Console.ReadLine(), out date1);
            Console.Write("Enter second date in dd.MM.yyyy format: ");
            DateTime date2;
            bool endDateParse = DateTime.TryParse(Console.ReadLine(), out date2);

            if (startDateParse && endDateParse)
            {
                Console.WriteLine("Time Difference (days): " + (date2 - date1).TotalDays);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
