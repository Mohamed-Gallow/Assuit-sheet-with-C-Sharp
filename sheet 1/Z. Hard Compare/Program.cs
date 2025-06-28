using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z.Hard_Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]nums=Console.ReadLine().Split();
            double a=double.Parse(nums[0]);
            double b=double.Parse(nums[1]);   
            double c=double.Parse(nums[2]);
            double d=double.Parse(nums[3]);
            //هيحصل اوفرفلو فا هاخد لوغاريتم الطرفين علشان اقلل القيملة  a^b ===> b*log(a)
            if (b*Math.Log(a) > d * Math.Log(c))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
