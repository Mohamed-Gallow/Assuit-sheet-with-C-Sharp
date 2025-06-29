using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Equation
{
    internal class Program
    {
        static double Equition(int x,int n)
        {
            double result=0;
            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    result += Math.Pow(x,i);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            String[] nums = Console.ReadLine().Split();
            int x = int.Parse(nums[0]);
            int y = int.Parse(nums[1]);

            Console.WriteLine(Equition(x,y));
        }
    }
}
