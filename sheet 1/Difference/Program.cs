using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            long a = long.Parse(nums[0]);
            long b = long.Parse(nums[1]);
            long c = long.Parse(nums[2]);
            long d = long.Parse(nums[3]);

            Console.WriteLine("Difference"+" "+"="+" "+((a*b)-(c*d)));

        }
    }
}
