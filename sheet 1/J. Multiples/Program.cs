using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int a=int.Parse(nums[0]);
            int b=int.Parse(nums[1]);

            if(a%b == 0 || b%a==0)
            {
                Console.WriteLine("Multiples");
            }
            else
            {
                Console.WriteLine("No Multiples");
            }
        }
    }
}
