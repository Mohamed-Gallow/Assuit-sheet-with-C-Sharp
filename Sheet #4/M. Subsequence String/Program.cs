using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Subsequence_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string test = "hello";
            int count = 0;

            for (int i = 0; i < s.Length && count < test.Length; i++)
            {
                if (s[i] == test[count])
                    count++;
            }

            if (count == test.Length)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
