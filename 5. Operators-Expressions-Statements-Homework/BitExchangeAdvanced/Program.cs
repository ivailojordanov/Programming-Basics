using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchangeAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("p= ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("q= ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of {0} is: {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
            for (int i = p; i <= p + k - 1; i++)
            {
                uint mask = 1;
                uint bitQ = (n & (mask << q)) >> q;
                uint bitP = (n & (mask << i)) >> i;
                n = n & ~(mask << i);
                n = n & ~(mask << q);
                n = n | (bitQ << i);
                n = n | (bitP << q);          
                q++;
            }
            Console.WriteLine("Binary representation of {0} is: {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
        }
    }
}
