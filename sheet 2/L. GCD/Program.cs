using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.GCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);
            int div = 0;
            for (int i = 1;i<= Math.Min(a,b);i++)
            {
                if (a % i == 0 && b % i == 0)
                    div = i;    
            }
            Console.WriteLine(div);
        }
    }
}
