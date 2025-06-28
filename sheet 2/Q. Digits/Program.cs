using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t, n;
            t=int.Parse(Console.ReadLine());

            for(int i=0; i<t; i++)
            {
                n=int.Parse(Console.ReadLine());
                if (n == 0)
                    Console.Write(0 + " ");
                else
                {
                    while (n > 0)
                    {
                        Console.Write(n % 10 + " ");
                        n /= 10;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
