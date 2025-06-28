using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Sum_of_Consecutive_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string[] nums=Console.ReadLine().Split();
                int x = int.Parse(nums[0]);
                int y = int.Parse(nums[1]);
                int sum = 0;
                for(int j=(Math.Min(x, y))+1; j < Math.Max(x, y);j++)
                {
                    if (j % 2 != 0)
                        sum += j;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
