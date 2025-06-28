using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Max_and_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums=Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);
            int c = int.Parse(nums[2]);

            if(a>=b && a>=c)
            {
                if(b>c)
                {
                    Console.WriteLine(c+" "+a);
                }
                else
                {
                    Console.WriteLine(b + " " + a);
                }
            }
            else if (b >= a && b >= c)
            {
                if (a > c)
                {
                    Console.WriteLine(c + " " + b);
                }
                else
                {
                    Console.WriteLine(a + " " + b);
                }
            }
            else if (c >= a && c >= b)
            {
                if (a > b)
                {
                    Console.WriteLine(b + " " + c);
                }
                else
                {
                    Console.WriteLine(a + " " + c);
                }
            }
            

        }
    }
}
