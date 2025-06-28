using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Winter_Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            double x = int.Parse(nums[0]);
            double p = int.Parse(nums[1]);

            double oldPricec=-((p * 100)/(x-100));
            Console.WriteLine(oldPricec);
            
        }
    }
}
