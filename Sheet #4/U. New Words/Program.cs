using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.New_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            
            int e = 0, g = 0, y = 0, p = 0, t = 0;

            for(int i=0; i<s.Length; i++)
            {
                e += (s[i] == 'e') ? 1 : 0;
                g += (s[i] == 'g') ? 1 : 0;
                y += (s[i] == 'y') ? 1 : 0;
                p += (s[i] == 'p') ? 1 : 0;
                t += (s[i] == 't') ? 1 : 0;
            }
            Console.WriteLine(Math.Min(e,Math.Min(g,Math.Min(y,Math.Min(p,t)))));
        }
    }
}
