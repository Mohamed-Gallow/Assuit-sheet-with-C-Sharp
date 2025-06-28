using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N.Numbers_Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sympol = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string[] nums=Console.ReadLine().Split();
            
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(nums[i]);

                for(int j = 0; j < x; j++)
                {
                    Console.Write(sympol);
                }
                Console.WriteLine();
            }
        }
    }
}
