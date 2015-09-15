using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ivaylo";
            string lastName = "Yordanov";
            byte age = 21;
            char gender = 'm';
            string personalID = "4308123212";
            string employeeNumber = "23562324";

            Console.WriteLine("First name: {0}\t\t | type: {1}", firstName, firstName.GetTypeCode());
            Console.WriteLine("Last name: {0}\t\t | type: {1}", lastName, lastName.GetTypeCode());
            Console.WriteLine("Age: {0}\t\t\t\t | type: {1}", age, age.GetTypeCode());
            Console.WriteLine("Gender: {0}\t\t\t | type: {1}", gender, gender.GetTypeCode());
            Console.WriteLine("Personal ID: {0}\t\t | type: {1}", personalID, personalID.GetTypeCode());
            Console.WriteLine("Unique Employee number: {0} | type: {1}", employeeNumber, employeeNumber.GetTypeCode());
        }
    }
}
