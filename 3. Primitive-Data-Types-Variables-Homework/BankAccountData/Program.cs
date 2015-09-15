using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ivaylo";
            string middleName = "Krasimirov";
            string lastName = "Yordanov";
            double balance = 6666666666666;
            string bankName = "Unicredit Bulbank";
            string IBAN = "BG83UNCR06112507";
            string CreditCard1 = "1234567898765342";
            string CreditCard2 = "2345678987654321";
            string CreditCard3 = "3456789876543210";

            Console.WriteLine("First name: {0}\t\t | type: {1}", firstName, firstName.GetTypeCode());
            Console.WriteLine("Middle name: {0}\t\t | type: {1}", middleName, middleName.GetTypeCode());
            Console.WriteLine("Last name: {0}\t\t | type: {1}", lastName, lastName.GetTypeCode());
            Console.WriteLine("Balance: {0}\t\t | type: {1}", balance, balance.GetTypeCode());
            Console.WriteLine("Bank name: {0}\t\t | type: {1}", bankName, bankName.GetTypeCode());
            Console.WriteLine("IBAN : {0}\t\t | type: {1}", IBAN, IBAN.GetTypeCode());
            Console.WriteLine("Credit cards: \nCredit card: {0}\t | type: {3}\nCredit card: {1}\t | type: {4}\nCredit card: {2}\t | type: {5}", CreditCard1, CreditCard2, CreditCard3, CreditCard1.GetTypeCode(), CreditCard2.GetTypeCode(), CreditCard3.GetTypeCode());
        }
    }
}
