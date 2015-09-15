using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Company Information: ");
            Console.WriteLine("Enter Company Name: ");
            string CompanyName = Console.ReadLine();
            Console.WriteLine("Enter Company Address: ");
            string CompanyAddress = Console.ReadLine();
            Console.WriteLine("Enter Company Phone Number: ");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Company Fax Number: ");
            string FaxNumber = Console.ReadLine();
            if (FaxNumber == "")
            {
                FaxNumber = "(no fax)";
            }
            Console.WriteLine("Enter Company Website: ");
            string WebSite = Console.ReadLine();
            Console.WriteLine("Enter Manager First Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Manager Last Name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Manager Age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Manager Phone Number: ");
            string ManagerPhone = Console.ReadLine();

            Console.WriteLine("\n{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: \n{7}, tel. {8})", CompanyName, CompanyAddress, PhoneNumber, FaxNumber, WebSite, FirstName, LastName, Age, ManagerPhone);
        }
    }
}
