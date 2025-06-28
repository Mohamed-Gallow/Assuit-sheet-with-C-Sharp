using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.Count_Subarrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while(t > 0)
            {
                int n= int.Parse(Console.ReadLine());
                string[] nums = Console.ReadLine().Split();
                for(int i = 0; i < n; i++)
                {
                    int x = int.Parse(nums[i]);
                }
                int sub = 0;
                for(int l = 0;l < n; l++)
                {
                    sub++; // for each element alone
                    for(int r =l+1; r < n; r++)
                    {
                        if (int.Parse(nums[r]) >= int.Parse(nums[r - 1]))
                            sub++;
                        else
                            break;
                    }
                }

                Console.WriteLine(sub);


                t--;
            }
        }
    }
}
