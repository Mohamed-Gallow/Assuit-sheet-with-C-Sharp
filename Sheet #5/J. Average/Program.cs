using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.Average
{
    internal class Program
    {
        static void Average(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum/arr.Length);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            double[] arr = new double[n];
            for (int i = 0;i < n; i++)
            {
                arr[i] = double.Parse(nums[i]);
            }
            Average(arr);
        }
    }
}
