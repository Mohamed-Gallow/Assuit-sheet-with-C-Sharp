using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Prime_checking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int flag = 0;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1 || n == 1)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}
