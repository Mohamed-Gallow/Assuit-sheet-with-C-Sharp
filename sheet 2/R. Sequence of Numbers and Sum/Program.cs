using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.Sequence_of_Numbers_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
            *wrong answer in test 3
            * string[] nums = Console.ReadLine().Split();
            int n =int.Parse(nums[0]);
            int m =int.Parse(nums[1]);
            int x = n,y=m;
            for(int j=Math.Min(x,y);j<=Math.Max(x,y); j++)
            {
                if (n > 0 && m > 0)
                {
                    int sum = 0;
                    for (int i = Math.Min(n, m); i <= Math.Max(n, m); i++)
                    {
                        Console.Write(i + " ");
                        sum += i;
                    }
                    Console.Write("sum =" + sum);
                    Console.WriteLine();
                }
                else
                {
                    break;
                }

                nums = Console.ReadLine().Split();
                n = int.Parse(nums[0]);
                m = int.Parse(nums[1]);
            }
            */
           while(true)
            {
                string[] nums = Console.ReadLine().Split();
                int n = int.Parse(nums[0]);
                int m = int.Parse(nums[1]);

                if (n <= 0 || m <= 0)
                    break;

                int sum=0;
                for (int i = Math.Min(n, m); i <= Math.Max(n, m); i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                Console.Write("sum =" + sum);
                Console.WriteLine();


            }
            
        }
    }
}
