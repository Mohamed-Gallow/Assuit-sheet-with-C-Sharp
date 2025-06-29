using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Sort_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string[] chara = Console.ReadLine().Split();

            int[] frec = new int[26];
            for(int i = 0; i < n; i++)
            {
                char s = char.Parse(chara[i]);
                frec[s-'a']++;
            }
            for(int i = 0;i < frec.Length; i++)
            {
                if(frec[i] != 0)
                {
                    for(int j = 0;j < frec[i]; j++)
                        Console.Write((char)(i+'a'));
                }
            }
            
        }
    }
}
