using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W.Mirror_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int m = int.Parse(nums[1]);

            int[,] arr = new int[n,m];

            for(int i = 0; i < n; i++)
            {
                string[] items = Console.ReadLine().Split();
                for(int j = 0; j < m; j++)
                {
                    arr[i,j] = int.Parse(items[j]);
                }
            }
            for(int i = 0; i < n;i++)
            {
                for(int j = m-1; j >= 0; j--)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
