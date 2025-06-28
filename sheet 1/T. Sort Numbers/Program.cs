using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);
            int c = int.Parse(nums[2]);

            if(a >=b && a >=c)
            {
                if(b>c)
                {
                    Console.WriteLine(c + "\n" + b + "\n" + a +"\n");
                    Console.WriteLine(a + "\n" + b + "\n" + c);
                }
                else
                {
                    Console.WriteLine(b + "\n" + c + "\n" + a + "\n");
                    Console.WriteLine(a + "\n" + b + "\n" + c);
                }
            }
            else if (b >= a && b >= c)
            {
                if (a > c)
                {
                    Console.WriteLine(c + "\n" + a + "\n" + b + "\n");
                    Console.WriteLine(a + "\n" + b + "\n" + c);
                }
                else
                {
                    Console.WriteLine(a + "\n" + c + "\n" + b + "\n");
                    Console.WriteLine(a + "\n" + b + "\n" + c);
                }
            }
            else if (c >= a && c >= b)
            {
                if (a > b)
                {
                    Console.WriteLine(b + "\n" + a + "\n" + c + "\n");
                    Console.WriteLine(a + "\n" + b + "\n" + c);
                }
                else
                {
                    Console.WriteLine(a + "\n" + b + "\n" + c + "\n");
                    Console.WriteLine(a + "\n" + b + "\n" + c);
                }
            }
        }
    }
}
