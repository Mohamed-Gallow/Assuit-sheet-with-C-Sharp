using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.Is_B_a_subsequence_of_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int m = int.Parse(nums[1]);

            string[] a = Console.ReadLine().Split();
            string[] b = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(a[i]);
            }
            for (int i = 0; i < m; i++)
            {
                int x = int.Parse(b[i]);
            }

            int indx = 0;
            
            for(int i=0; i <n && indx <m; i++)
            {
                if(a[i] == b[indx])
                {
                    indx++;
                }
            }
            if (indx == m)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
