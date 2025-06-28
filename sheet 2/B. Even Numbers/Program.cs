using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if(n == 1)
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
