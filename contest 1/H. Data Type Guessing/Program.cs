using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Data_Type_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // there is an error i can not recognise it ^_^
                                                          

            // solution from youtube

            string[] nums = Console.ReadLine().Split();
            double n = double.Parse(nums[0]);
            double k = double.Parse(nums[1]);
            double a = double.Parse(nums[2]);

            
            long l =(long)((n * k) / a);
            double d = (n * k) / a, test = d - l;
            
            if (test > 0)
                Console.WriteLine("double");
            else if (l <= 2147483647)
                Console.WriteLine("int");
            else
                Console.WriteLine("long long");


            




            /*
             * wrong answer in test 3
             * string res = ((n*k)/a).ToString();
            
            if(res.Contains('.'))
            {
                Console.WriteLine("double");
            }
            else
            {
                long numResult = Convert.ToInt64(res);
                if(numResult > 2147483647)
                {
                    Console.WriteLine("long long");
                }
                else
                {
                    Console.WriteLine("int");
                }
            }
            */
        }
    }
}
