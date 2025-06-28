using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z.Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums=Console.ReadLine().Split();
            int k = int.Parse(nums[0]);
            int s = int.Parse(nums[1]);
            int counter = 0;
            for(int i=0;i<=k;i++)
            {
                for(int j=0;j<=k;j++)
                {
                    if(s-i-j >=0 && s-i-j <= k)
                        counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
