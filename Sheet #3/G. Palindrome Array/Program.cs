using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Palindrome_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int flag = 0;
            string[] nums = Console.ReadLine().Split();
            for(int i=0; i<n; i++)
            {
                int x =int.Parse(nums[i]);
            }
            for(int i =0; i<n/2; i++)
            {
                if(nums[i] != nums[n-i-1])
                {
                    Console.WriteLine("NO");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
