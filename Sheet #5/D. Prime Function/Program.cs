using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Prime_Function
{
    internal class Program
    {
        static bool Prime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    return false;               
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                if (Prime(n))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
                t--;
            }
            
        }
    }
}
