using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Two_intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums=Console.ReadLine().Split();
            int l1=int.Parse(nums[0]);
            int r1=int.Parse(nums[1]);
            int l2=int.Parse(nums[2]);
            int r2=int.Parse(nums[3]);

            if (Math.Max(l1, l2) > Math.Min(r1, r2))
                Console.WriteLine(-1);
            else
                Console.WriteLine(Math.Max(l1, l2) + " " + Math.Min(r1, r2));

        }
    }
}
