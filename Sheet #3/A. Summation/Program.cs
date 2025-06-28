using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            long sum = 0;
            string[] nums = Console.ReadLine().Split();
            for(int i=0; i<n; i++)
            {
                int x=int.Parse(nums[i]);
                sum += x;
            }
            if(sum >=0)
                Console.WriteLine(sum);
            else
                Console.WriteLine(Math.Abs(sum));
        }
    }
}
