using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Way_Too_Long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while(t > 0)
            {
                string s = Console.ReadLine();
                if(s.Length <= 10)
                    Console.WriteLine(s);
                else
                    Console.WriteLine(s[0]+(s.Length-2).ToString()+s[s.Length-1]);

                t--;
            }
        }
    }
}
