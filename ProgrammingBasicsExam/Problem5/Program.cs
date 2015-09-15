using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split().Select(long.Parse).ToList<long>();
            List<string> binary = new List<string>();
            for (int i = 0; i < input.Count - 1; i += 2)
            {
                char[] x = Convert.ToString(input[i], 2).PadLeft(63, '0').ToCharArray();
                char[] y = Convert.ToString(input[i + 1], 2).PadLeft(63, '0').ToCharArray();

                SwitchBits(x, y);
                ReverseBits(x);
                ReverseBits(y);
                Console.WriteLine("{0} {1}", Convert.ToUInt64(String.Join("", x), 2), String.Join("", x));
                Console.WriteLine("{0} {1}", Convert.ToUInt64(String.Join("", y), 2), String.Join("", y));
            }
        }

        private static void ReverseBits(char[] x)
        {
            for (int h = 0; h < x.Length; h++)
            {
                if (x[h] == '1')
                {
                    x[h] = '0';
                }
                else if (x[h] == '0')
                {
                    x[h] = '1';
                }
            }
        }

        private static void SwitchBits(char[] x, char[] y)
        {
            for (int j = x.Length - 1; j >= 0; j -= 2)
            {
                x[j] ^= y[j];
                y[j] ^= x[j];
                x[j] ^= y[j];
            }
        }
    }
}
