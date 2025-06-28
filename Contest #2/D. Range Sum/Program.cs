using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Range_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int l = int.Parse(nums[0]);
                int r = int.Parse(nums[1]);
                long min = Math.Min(l, r);
                long max = Math.Max(l, r);
                min--; // علشان لما اطرح انا محتاج ال الرقم الاولاني معايا فبنقص منه واحد علشان نطرح من اول الرقم اللي قبله
                long sum1 = min*(min+1)/2;
                long sum2 = max*(max+1)/2;
                Console.WriteLine(sum2-sum1);
                
            }
        }
    }
}
