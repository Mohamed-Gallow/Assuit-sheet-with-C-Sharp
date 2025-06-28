using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Replace_MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            for(int i =0; i<n; i++)
            {
                int x = int.Parse(nums[i]);
            }

            int max=int.Parse(nums[0]);
            int min = int.Parse(nums[0]);
            
            for(int i =0; i<n; i++)
            {
                if(int.Parse(nums[i]) > max)
                    max = int.Parse(nums[i]);
                if(int.Parse(nums[i]) < min)
                    min = int.Parse(nums[i]);
            }
            for(int j =0; j<n; j++)
            {
                if (int.Parse(nums[j]) == min)
                {
                    nums[j] = max.ToString();
                    continue;
                }
                if (int.Parse(nums[j]) == max)
                {
                    nums[j] = min.ToString();
                    continue;
                }
            }
            foreach(string s in nums)
                Console.Write(s+" ");


        }
    }
}
