using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y.The_last_2_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums=Console.ReadLine().Split();
            int a=int.Parse(nums[0]);
            int b=int.Parse(nums[1]);
            int c=int.Parse(nums[2]);
            int d=int.Parse(nums[3]);

            //هجيب % 100 لكل رقم علشان لو ضربتهم في بعض كده ممكن يحصل اوفرفلو وهو كدخ كده لما اجي اجيب اخر رقمين في النتيجة هيبقو هم هم

            int num1 = a % 100;
            int num2 = b % 100;
            int num3 = c % 100;
            int num4 = d % 100;

            int result= (num1 * num2 * num3 * num4);

            if (result%100 <= 9)
            {
                Console.WriteLine("0"+(result%100));
                //علشان او 09 مثلا هيطبعها 9 بس 
            }
            else
            {
                Console.WriteLine(result%100);
            }

             
        }
    }
}
