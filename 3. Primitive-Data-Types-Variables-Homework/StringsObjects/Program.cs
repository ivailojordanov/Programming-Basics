using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            string s1 = " World";
            Object obj = s + s1;
            string s2 = (string)obj;
            Console.WriteLine(s2);
        }
    }
}
