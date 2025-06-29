using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Add
{
    internal class Program
    {
        static int sum(int num1,int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int num1 = int.Parse(nums[0]);
            int num2 = int.Parse(nums[1]);
            Console.WriteLine(sum(num1,num2));
        }
    }
}
