using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Adding_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);

            // direct solution with xor
            //Console.WriteLine(a ^ b);

            // another solution
            double dec =0;
            for(int i=0; i<32; i++)
            {
                int x = a % 2;
                a = a / 2;
                int y = b % 2;
                b = b / 2;

                if(x != y)
                {
                    dec = dec + Math.Pow(2,i);
                }

            }
            Console.WriteLine(dec);
        }
    }
}
