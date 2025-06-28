using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.Some_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n =int.Parse(nums[0]);
            int a =int.Parse(nums[1]);
            int b =int.Parse(nums[2]);
            
            int totalSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = i;
                int sum = 0;

                while (x > 0)
                {
                    sum += x % 10;
                    x = x / 10;  
                }
                if (sum >= a && sum <= b)
                    totalSum += i;
            }
            Console.WriteLine(totalSum);
        }
    }
}
