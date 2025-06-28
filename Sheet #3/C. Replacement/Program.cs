using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Replacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();

            for(int i=0; i<n; i++)
            {
                int x =int.Parse(nums[i]);
                if (x > 0)
                    nums[i] = "1";
                else if(x < 0)
                    nums[i]= "2";
            }
            foreach(string s in nums)
                Console.Write(s+" ");
        }
    }
}
