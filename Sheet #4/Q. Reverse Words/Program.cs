using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.Reverse_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] words = s.Split(' ');
            for (int j=0; j<words.Length;j++)
            {
                StringBuilder sb = new StringBuilder();
                for(int i = words[j].Length-1; i >= 0; i--)
                {
                    sb.Append(words[j][i]);
                }
                if(j != words.Length-1)
                    sb.Append(" ");
                Console.Write(sb);
            }
        }
    }
}
