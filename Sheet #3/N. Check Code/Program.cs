using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N.Check_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);
            string s = Console.ReadLine();

            if (s[a] != '-')
            {
                Console.WriteLine("No");
                return;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i == a)
                        continue;
                    else if (s[i] >= '0' && s[i] <= '9') ;
                    else
                    {
                        Console.WriteLine("No");
                        return;
                    }

                }
                Console.WriteLine("Yes");
            }
        }
    }
}

