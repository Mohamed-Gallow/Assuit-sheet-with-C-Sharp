using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Digits_Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums =Console.ReadLine().Split();
            long a =long.Parse(nums[0]);
            long b = long.Parse(nums[1]);

            Console.WriteLine((a % 10)+(b % 10));
        }
    }
}
