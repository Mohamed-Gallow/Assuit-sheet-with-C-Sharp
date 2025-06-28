using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Lowest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int num, index=0;
            for(int i =0; i < n;i++)
            {
                int x = int.Parse(nums[i]);
            }
            num = int.Parse(nums[0]);
            for (int j =0; j < n;j++)
            {
                if(int.Parse(nums[j]) < num)
                {
                    num = int.Parse(nums[j]);
                    index= j;
                }
            }
            Console.WriteLine(num+" "+(index+1));
        }
    }
}
