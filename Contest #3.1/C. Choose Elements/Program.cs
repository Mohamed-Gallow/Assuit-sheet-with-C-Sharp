using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Choose_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int k = int.Parse(nums[1]);

            string[] arr = Console.ReadLine().Split();
            long [] intArr = new long[n];
            for(int i=0; i<n; i++)
            {
                intArr[i] = long.Parse(arr[i]);
            }
            Array.Sort(intArr);
            Array.Reverse(intArr);
            long sum = 0;
            
            for(int i=0; i<k; i++)
            {
                if (intArr[i] < 0)
                    break;
                sum += intArr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
