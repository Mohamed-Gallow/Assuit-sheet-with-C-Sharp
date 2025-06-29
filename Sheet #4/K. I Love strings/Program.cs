using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.I_Love_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                string[] str = Console.ReadLine().Split();
                string s = str[0];
                string t = str[1];
                StringBuilder sb = new StringBuilder();

                for(int i = 0; i < Math.Max(s.Length,t.Length); i++)
                {
                    if (i < s.Length)
                        sb.Append(s[i]);
                    if(i < t.Length)
                        sb.Append(t[i]);
                }
                Console.WriteLine(sb);
                n--;
            }
        }
    }
}
