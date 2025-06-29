using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Power_Of_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
           
            if (n>0 && (n & (n-1)) == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
