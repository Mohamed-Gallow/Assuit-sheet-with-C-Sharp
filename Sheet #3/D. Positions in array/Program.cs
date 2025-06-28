using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Positions_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();

            for(int i=0; i<n; i++)
            {
                int x = int.Parse(nums[i]);
            }
            for(int x=0; x<n; x++)
            {
                if(int.Parse(nums[x]) <= 10)
                {
                    Console.WriteLine("A["+x+"] = "+nums[x]);
                }
            }
        }
    }
}
