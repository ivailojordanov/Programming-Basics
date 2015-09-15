using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    printtop(n);
                }
                else
                {
                    printmiddle(n, i);
                }
            }
        }

        private static void printmiddle(int n, int i)
        {
            string lens = new string('/', n * 2 - 2);
            string middleFrame = string.Format("{0}{1}{0}", '*', lens);
            string connection = new string(' ', n);
            if (i == n / 2)
            {
                connection = new string('|', n);
            }
            Console.WriteLine("{0}{1}{0}", middleFrame, connection);
        }

        private static void printtop(int n)
        {
            string frame = new string('*', 2 * n);
            string emptySpace = new string(' ', n);
            Console.WriteLine("{0}{1}{0}", frame, emptySpace, frame);
        }
    }
}
