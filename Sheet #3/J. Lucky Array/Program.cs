using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.Lucky_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(nums[0]);
            }
            int min = int.Parse(nums[0]);

            for(int i = 0; i < n;i++)
            {
                if(int.Parse(nums[i]) < min)
                {
                    min = int.Parse(nums[i]);
                }
            }
            int frec = 0;
            for(int i = 0; i < n;i++)
            {
                if(int.Parse(nums[i]) == min)
                {
                    frec++;
                }
            }
            if (frec % 2 == 0)
                Console.WriteLine("Unlucky");
            else
                Console.WriteLine("Lucky");
            
        }
    }
}
