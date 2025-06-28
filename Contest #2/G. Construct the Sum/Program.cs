using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Construct_the_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int n = int.Parse(nums[0]);
                long s = long.Parse(nums[1]);

                List<int> list = new List<int>();
                long sum = 0;

                for(int j = n; j >=1 ; j--)
                {
                    if(sum+j <= s)
                    {
                        sum = sum+j;
                        list.Add(j);
                    }
                }
                if(sum != s)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    foreach(int q in list)
                        Console.Write(q+" ");
                    Console.WriteLine();
                }
            }
        }
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine()); // Number of test cases

        for (int t = 0; t < T; t++)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]); // Upper limit
            long s = long.Parse(input[1]); // Sum

            List<int> numbers = new List<int>();
            long sum = 0;

            // Finding distinct positive integers that sum up to 's'
            for (int i = n; i >= 1 && sum < s; i--)
            {
                if (sum + i <= s)
                {
                    numbers.Add(i);
                    sum += i;
                }
            }

            // If sum is not equal to 's', it's impossible
            if (sum != s)
            {
                Console.WriteLine("-1");
            }
            else
            {
                numbers.Reverse(); // Reversing to print in ascending order
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
*/

