using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Search_In_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int m = int.Parse(nums[1]);

            int[,] mat = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                string[] items = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                { 
                    mat[i, j] = int.Parse(items[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for(int j =0; j < m; j++)
                {
                    if(x == mat[i, j])
                    {
                        Console.WriteLine("will not take number");
                        return;
                    }
                }
            }
            Console.WriteLine("will take number");
        }
    }
}
