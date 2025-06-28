using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.The_Brothers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names1=Console.ReadLine().Split();
            string f1=names1[0];
            string s1=names1[1];
            string[] names2 = Console.ReadLine().Split();
            string f2=names2[0];
            string s2=names2[1];

            if(s1 == s2)
            {
                Console.WriteLine("ARE Brothers");
            }
            else
            {
                Console.WriteLine("NOT");
            }
        }
    }
}
