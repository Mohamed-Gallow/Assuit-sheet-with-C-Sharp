using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] nums= Console.ReadLine().Split();
            long a = long.Parse(nums[0]);
            long b = long.Parse(nums[1]);

            Console.WriteLine(a + " " + "+" + " " + b + " " + "=" + " " + (a + b));
            Console.WriteLine(a + " " + "*" + " " + b + " " + "=" + " " + (a * b));
            Console.WriteLine(a + " " + "-" + " " + b + " " + "=" + " " + (a - b));

        }
    }
}
