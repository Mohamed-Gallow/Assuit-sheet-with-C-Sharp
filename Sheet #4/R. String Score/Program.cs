using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.String_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder(s);
            
            int score = 0;

            for(int i = 0; i < sb.Length; i++)
            {
                if(sb[i] == 'V')
                {
                    score += 5;
                }
                else if(sb[i] == 'W')
                {
                    score += 2;
                }
                else if(sb[i] == 'X')
                {
                    i++;

                }
                else if(sb[i] == 'Y' && i+1 < sb.Length)
                {
                        sb.Append(sb[i + 1]);
                        i++;
                }
                else if (sb[i] == 'Z' && i + 1 < sb.Length)
                {
                    if(sb[i+1] == 'V')
                    {
                        score /= 5;
                        i++;
                    }
                    else if (sb[i + 1] == 'W')
                    {
                        score /= 2;
                        i++;
                    }
                }
            }
            Console.WriteLine(score);
        }
    }
}
