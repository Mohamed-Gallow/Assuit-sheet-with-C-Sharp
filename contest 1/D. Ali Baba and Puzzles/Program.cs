using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Ali_Baba_and_Puzzles
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

            if (d == a + b - c || d == a + b * c || d == a - b + c || d == a * b + c || d == a - b * c || d == a * b - c)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
