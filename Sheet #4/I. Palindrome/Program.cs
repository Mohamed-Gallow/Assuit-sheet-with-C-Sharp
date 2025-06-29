using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int flag = 0;
            for(int i =0; i < s.Length/2; i++)
            {
                if(s[i] == s[s.Length-1-i])
                {
                    flag = 0;
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
