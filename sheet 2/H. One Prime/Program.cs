using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.One_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, flag = 0;
            n=int.Parse(Console.ReadLine());    

            for(int i = 2;i < n/2;i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("NO");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("YES");
        }
    }
}
