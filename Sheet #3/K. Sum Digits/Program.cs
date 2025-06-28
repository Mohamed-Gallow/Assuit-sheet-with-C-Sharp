using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string nums=Console.ReadLine();
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += nums[i] - '0';
            }
            Console.WriteLine(sum);


        }
    }
}
