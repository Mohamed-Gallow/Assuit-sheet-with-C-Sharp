using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Max_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while(t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] nums= Console.ReadLine().Split();
                for(int i=0; i<n; i++)
                {
                    int x = int.Parse(nums[i]);
                }
                for(int l=0; l<n;l++)
                {
                    for(int r=l; r<n; r++)
                    {
                        int max = int.Parse(nums[l]);
                        for(int c=l; c<=r; c++)
                        {
                            if(int.Parse(nums[c])>max)
                                max = int.Parse(nums[c]); 
                        }
                        Console.Write(max+" ");
                    }
                }

                Console.WriteLine();

                t--;
            }
        }
    }
}
