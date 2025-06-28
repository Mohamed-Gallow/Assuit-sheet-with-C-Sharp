using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Interval_Sweep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);

            if (a - b == 1 || b - a == 1 || (a == b && a!= 0 && b != 0) )
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
