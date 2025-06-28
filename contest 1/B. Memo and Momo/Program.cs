using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Memo_and_Momo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            long a = long.Parse(nums[0]);
            long b = long.Parse(nums[1]);
            long k = long.Parse(nums[2]);

            if (a % k == 0 && b % k == 0)
                Console.WriteLine("Both");
            else if (a % k == 0 && b % k != 0)
                Console.WriteLine("Memo");
            else if (a % k != 0 && b % k == 0)
                Console.WriteLine("Momo");
            else
                Console.WriteLine("No One");

        }
    }
}
