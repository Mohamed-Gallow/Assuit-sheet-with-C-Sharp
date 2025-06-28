using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Timon_and_Pumbaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);

            if (a - b >= 0)
                Console.WriteLine(a - b);
            else
                Console.WriteLine(0);
        }
    }
}
