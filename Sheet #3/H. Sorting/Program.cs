using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            string[]nums = Console.ReadLine().Split();
            int min;
            int swp;

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(nums[i]);
            }
            for(int i = 0; i < n;i++)
            {
                min = int.Parse(nums[i]);
                for (int j = i; j < n; j++)
                {
                    if(int.Parse(nums[j]) < min)
                    {
                        swp = min;
                        min = int.Parse(nums[j]);
                        nums[j] = swp.ToString();
                    }
                }
                nums[i] = min.ToString();
            }
            foreach (string s in nums)
                Console.Write(s + " ");
        }
    }
}
