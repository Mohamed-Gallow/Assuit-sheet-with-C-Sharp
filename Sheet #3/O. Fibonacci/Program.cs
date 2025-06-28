using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n =long.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine(0);
            else
            {
                long[] fib = new long[n];
                fib[0] = 0;
                fib[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }

                Console.WriteLine(fib[n - 1]);
            }
        }
    }
}
