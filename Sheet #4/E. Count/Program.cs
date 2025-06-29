using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long sum = 0;
            for(int i=0; i<s.Length; i++)
            {
                sum += int.Parse(s[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
