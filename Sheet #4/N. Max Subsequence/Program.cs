using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N.Max_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int count = 0;

            for(int i = 0; i < n-1; i++)
            {
                if(s[i] != s[i+1])
                    count++;
            }
            Console.WriteLine(count+1);
        }
    }
}
