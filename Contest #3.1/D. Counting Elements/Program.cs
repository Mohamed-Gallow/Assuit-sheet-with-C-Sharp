using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Counting_Elements
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
            
            int sum = 0;
            
            for(int i = 0; i < n;i++)
            {
                int flag = 0;
                for (int j = 0; j < n; j++)
                {
                    if(arr[j] == arr[i]+1)
                    {
                        flag=1;
                        
                    }
                }
                sum += flag;
            }
            Console.WriteLine(sum);
        }
    }
}
