using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Max
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n= int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int max=0;
            for(int i=0;i<n;i++)
            {
                int x = int.Parse(nums[i]);
                if (x > max)
                    max = x;
            }
            Console.WriteLine(max);
        }
    }
}
