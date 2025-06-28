using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Summation_from_1_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            Console.WriteLine(n*(n+1)/2);

            //time limit
            /* int n=int.Parse(Console.ReadLine());
             long sum = 0;
             for(int i=1;i<=n;i++)
             {
                 sum += i;
             }
             Console.WriteLine(sum);
            */
        }
    }
}
