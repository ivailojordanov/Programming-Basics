using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int top = n + 1;
            int bottom = n + n;
            int neck = n - 1;
            int bottle = n + n;
            int num = 0;
            Console.WriteLine("{0}{1}", new string(' ', n / 2), new string('*', n + 1));
            for (int i = 0; i < neck; i++)
            {
                if (i < top / 2)
                {
                    Console.WriteLine("{0}{1}{2}{1}", new string(' ', n / 2), "*", new string(' ', n - 1));
                }
                else
                {
                    num++;
                    Console.WriteLine("{0}{1}{2}{1}", new string(' ', n / 2 - num), "*", new string(' ', n - 1 + 2 * num));
                }
            }
            for (int i = 0; i < bottle; i++)
            {
                if (i < bottle / 2)
                {
                    Console.WriteLine("{0}{1}{0}", "*", new string('.', (2 * n - 2)));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", "*", new string('@', (2 * n - 2)));
                }
            }
            for (int i = 0; i < bottom; i++)
            {
                Console.Write("*");
            }
        }
    }
}
