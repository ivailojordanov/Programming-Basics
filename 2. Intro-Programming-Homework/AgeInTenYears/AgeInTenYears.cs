using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeInTenYears
{
    class AgeInTenYears
    {
        static void Main(string[] args)
        {
            string date;
            Console.WriteLine("Enter your birthday in format dd/mm/yy: ");
            date =  Console.ReadLine();

            DateTime dt = Convert.ToDateTime(date);
            DateTime now = DateTime.Now;
            int age = now.Year - dt.Year;
            if (now.Month < dt.Month || (now.Month == dt.Month && now.Day < dt.Day))age--;
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("In 10 years you will be " + (age + 10) + " years old.");
        }
    }
}
