using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Minimize_Number
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
            int opr = 0;
            
            for(int i = 0; i<n; i++)
            {
                if (int.Parse(nums[i]) % 2 != 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            while(true)
            {
                for(int i=0; i<n;i++)
                {
                    nums[i] = (int.Parse(nums[i]) / 2).ToString();
                }
                opr++;
                for (int i = 0; i < n; i++)
                {
                    if (int.Parse(nums[i]) % 2 != 0)
                    {
                        Console.WriteLine(opr);
                        return;
                    }
                }
            }


        }
    }
}
