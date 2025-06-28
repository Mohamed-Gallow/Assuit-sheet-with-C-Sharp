using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());  

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                long fact = 1;
                for(int j =1;j <= n;j++)
                {
                    if (n == 0)
                    {
                        fact = 1;
                    }
                    else
                        fact *= j;
                }
                Console.WriteLine(fact);
            }
        }
    }
}
