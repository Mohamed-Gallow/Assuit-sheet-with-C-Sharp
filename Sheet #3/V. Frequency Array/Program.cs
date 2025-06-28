using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Frequency_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int m = int.Parse(nums[1]);

            string[] arr = Console.ReadLine().Split();
            int[] frec = new int[m];

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(arr[i]);
                frec[x-1]+=1;
            }
            for(int i =0; i <m; i++)
            {
                Console.WriteLine(frec[i]);
            }
            
        }
    }
}
