using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Shift_Right
{
    internal class Program
    {
        static void Shift(int[] arr, int x)
        {
            int n = arr.Length;
            int[] newArr = new int[n];
            for(int i=0; i<n; i++)
            {
                newArr[(i + x) % n] = arr[i];
            }    
            foreach(int i in newArr)
                Console.Write(i+" ");
        }
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int x = int.Parse(nums[1]);

            string[] items = Console.ReadLine().Split();
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(items[i]);
            }
            Shift(arr, x);
        }
    }
}
