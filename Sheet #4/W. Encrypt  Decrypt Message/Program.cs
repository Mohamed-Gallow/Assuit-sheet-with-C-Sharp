using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W.Encrypt__Decrypt_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s=Console.ReadLine();
            string Key = "PgEfTYaWGHjDAmxQqFLRpCJBownyUKZXkbvzIdshurMilNSVOtec#@_!=.+-*/";
            string Original = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder sb=new StringBuilder();

            for(int i=0; i<s.Length; i++)
            {
                if(n==1)
                {
                    for(int j=0; j<Original.Length; j++)
                    {
                        if(Original[j]==s[i])
                        {
                            sb.Append(Key[j]);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Key.Length; j++)
                    {
                        if (Key[j] == s[i])
                        {
                            sb.Append(Original[j]);
                        }
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
