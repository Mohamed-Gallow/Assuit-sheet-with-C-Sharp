using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N.Shift_Zeros
{
    internal class Program
    {
        static void Shift(int[] arr)
        {
            int n = arr.Length;
            int[] newArr = new int[n];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }
            foreach (int i in newArr)
                Console.Write(i+" ");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int[] arr = new int[n];
            for(int i = 0;i < n; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }
            Shift(arr);
        }
    }
}
