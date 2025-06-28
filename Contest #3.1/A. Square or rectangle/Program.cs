using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Square_or_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while(t>0)
            {
                string[] nums = Console.ReadLine().Split();
                int w = int.Parse(nums[0]);
                int h = int.Parse(nums[1]);

                if (w == h)
                    Console.WriteLine("Square");
                else
                    Console.WriteLine("Rectangle");
                t--;
            }
        }
    }
}
