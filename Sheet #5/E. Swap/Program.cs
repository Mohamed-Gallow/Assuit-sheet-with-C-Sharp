using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Swap
{
    internal class Program
    {
        static void Swap(int x, int y)
        {
            int z;
            z = x;
            x = y;
            y = z;
            Console.WriteLine(x+" "+y);
        }
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int x = int.Parse(nums[0]);
            int y = int.Parse(nums[1]);

            Swap(x, y);
        }
    }
}
