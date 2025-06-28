using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Smallest_Pair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] nums = Console.ReadLine().Split();
                long res = 0;
                for(int i = 0; i < n; i++)
                {
                    int x = int.Parse(nums[i]);
                }
                res = int.Parse(nums[0])+int.Parse(nums[1])+2-1;
                
                for(int i= 0;i<n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        if(int.Parse(nums[i]) + int.Parse(nums[j]) + (j+1) - (i+1) < res && j>i)
                        {
                            res = int.Parse(nums[i]) + int.Parse(nums[j]) + (j + 1) - (i + 1);
                        }
                    }
                }
                Console.WriteLine(res);
                t--;
            }
        }
    }
}
