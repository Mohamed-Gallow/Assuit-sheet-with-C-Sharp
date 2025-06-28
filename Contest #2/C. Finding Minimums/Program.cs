using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Finding_Minimums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums=Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int k = int.Parse(nums[1]);

            string[] numbers = Console.ReadLine().Split();
            int min=0;
            int counter =0,flag =1;
            

            for (int i = 0; i < n; i++)
            {
                int x=int.Parse(numbers[i]);
                if (flag == 1)  // to make min equal the first value  
                {
                    min = x;  
                    flag = 0;
                }
                else
                {
                    if (x < min)
                    {
                        min = x;
                    }
                }
                counter++;
                if(counter == k || i == n-1)  // n-1 because the loop begin from 0 to i<n to full the indexes of array numbers
                {
                    Console.Write(min+" ");
                    counter = 0;
                    flag = 1;
                }
                
                
            }

            

        }
    }
}
