using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.Count_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] frec = new int[123];
            for(int i=0; i<s.Length; i++)
            {
                frec[s[i]]++;
            }
            for(int i=0;i<123;i++)
            {
                if(frec[i] != 0)
                    Console.WriteLine((char)i + " : "+ frec[i]);
            }
        }
    }
}
