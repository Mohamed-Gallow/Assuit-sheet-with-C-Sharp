using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);
            int counter = -1;
            for (int i = a; i <= b; i++)
            {
                int x = i, lucky =0;
                while(x > 0)
                {
                    if(x%10 !=4 && x%10 !=7)
                        lucky++;
                    x = x / 10;
                }
                if (lucky == 0)
                {
                    Console.Write(i + " ");
                    counter++;
                }
            }
            if (counter == -1)
                Console.WriteLine(-1);
        }
    }
}
