using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Print_Recursion
{
    internal class Program
    {
        static void rec(int n)
        {
            if (n == 0)
                return;
            Console.WriteLine("I love Recursion");
            rec(n - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            rec(n);
        }
    }
}
