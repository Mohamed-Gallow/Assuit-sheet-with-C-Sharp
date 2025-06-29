using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.URL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s2="";
            for(int i =0; i < s.Length;i++)
            {
                if(s[i] == '?')
                    s2 = s.Substring(i+1, s.Length-i-1);
            }
            string[] x = s2.Split('&');
            for(int i=0; i<x.Length;i++)
            {
                Console.WriteLine(x[i].Substring(0,x[i].IndexOf('='))+": "+ x[i].Substring(x[i].IndexOf('=')+1 , x[i].Length- x[i].IndexOf('=')-1));
            }
        }
    }
}
