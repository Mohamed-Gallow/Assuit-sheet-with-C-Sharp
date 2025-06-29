using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Max_and_MIN
{
    internal class Program
    {
        static void MaxAndMIN(int[] arr)
        {
            Array.Sort(arr);
            Console.Write(arr[0]+" ");
            Console.Write(arr[arr.Length - 1]);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }
            MaxAndMIN(arr);
        }
    }
}
