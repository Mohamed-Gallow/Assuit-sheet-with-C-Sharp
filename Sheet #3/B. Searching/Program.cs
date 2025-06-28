using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums=Console.ReadLine().Split();
            int x = int.Parse(Console.ReadLine());
            int flag=0;

            for(int i=0; i<n; i++)
            {
                int y = int.Parse(nums[i]);
            }
            for(int i =0; i<n; i++)
            {
                flag = 0;
                if(int.Parse(nums[i]) == x)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    flag++;
                }
            }
            if(flag == 1)
                Console.WriteLine(-1);
            
        }
    }
}
