using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Even__Odd__Positive_and_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int odd = 0, even = 0, postive = 0, negative = 0;
            string[] nums = Console.ReadLine().Split();
            for (int i=0; i<n; i++)
            {
                int x = int.Parse(nums[i]);
                if (x % 2 == 0)
                    even += 1;
                else
                    odd += 1;
                if (x > 0)
                    postive += 1;
                else if (x < 0)
                    negative += 1;

            }
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);
            Console.WriteLine("Positive: " + postive);
            Console.WriteLine("Negative: " + negative);
        }
    }
}
