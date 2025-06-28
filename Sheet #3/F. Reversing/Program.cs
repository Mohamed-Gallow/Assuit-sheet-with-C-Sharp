using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();

            for(int i= 0;i<n;i++)
            {
                int x = int.Parse(nums[i]);
            }
            for(int x = n-1; x>=0;x--)
            {
                Console.Write(nums[x]+" ");
            }
        }
    }
}
