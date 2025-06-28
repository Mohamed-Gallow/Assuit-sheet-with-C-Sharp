using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Break_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            string[] nums=Console.ReadLine().Split();
            long counter = 0;
            long flag = 0;
            for(int i = 0; i < n; i++)
            {
                long x=long.Parse(nums[i]);
                counter = 0;
                while(x > 0)
                {
                    if (x % 2 == 0)
                    {
                        counter++;
                    }
                    else
                        break;
                    x /= 2;
                }
                if(counter > flag)
                    flag = counter;
            }
            Console.WriteLine(flag);
        }
    }
}
