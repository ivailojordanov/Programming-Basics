using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "The \"use\" of quotations ";
            string s1 = "causes difficulties.";
            string s2 = "The use of quotations ";
            string s3 = "causes difficulties.";
            Console.WriteLine(s + s1);
            Console.WriteLine(s2 + s3);
        }
    }
}
