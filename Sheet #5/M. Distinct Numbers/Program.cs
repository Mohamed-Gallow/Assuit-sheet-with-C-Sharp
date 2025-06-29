using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Distinct_Numbers
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split(); 
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                set.Add(arr[i]);                
            }
            Console.WriteLine(set.Count);

        }
    }
}
