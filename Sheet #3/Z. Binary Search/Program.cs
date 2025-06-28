using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z.Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int q = int.Parse(nums[1]);
            
            string[]sArr = Console.ReadLine().Split();
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(sArr[i]);
            }
            Array.Sort(arr);

            while(q>0)
            {
                int x = int.Parse(Console.ReadLine());
                int l = 0;
                int h = n - 1;
                int flag = 0;
                while (l <= h)
                {
                    int mid = (l + h) / 2;
                    if (x == arr[mid])
                    {
                        Console.WriteLine("found");
                        flag = 1;
                        break;
                    }
                    if (arr[mid] > x)
                        h = mid - 1;
                    else
                        l = mid + 1;
                }
                if(flag == 0)
                    Console.WriteLine("not found");
                q--;
            }
        }
    }
}
