using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums= Console.ReadLine().Split();
            double a =double.Parse(nums[0]);
            double b =double.Parse(nums[1]);

            double c = a / b;
            double d = c - (int)c;

            Console.WriteLine("floor " + a + " / " + b + " = " + Math.Floor(c));
            Console.WriteLine("ceil " + a + " / " + b + " = " + Math.Ceiling(c));
            if (d != 0.5)
            Console.WriteLine("round " + a + " / " + b + " = " + Math.Round(c));
            else
            Console.WriteLine("round " + a + " / " + b + " = " + (Math.Round(c)+1));




        }
    }
}
