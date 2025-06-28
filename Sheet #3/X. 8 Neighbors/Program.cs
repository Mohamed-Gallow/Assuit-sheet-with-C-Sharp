using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X._8_Neighbors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int m = int.Parse(nums[1]);

            char[,] mat = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                string items = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = items[j];
                }
            }

            string[] test = Console.ReadLine().Split();
            int x = int.Parse(test[0]);
            int y = int.Parse(test[1]);
            if (x != 1 && y != 1)
            {
                x--;
                y--;
            }

            if (mat[x - 1, y - 1] != '.' && mat[x - 1, y] != '.' && mat[x - 1, y + 1] != '.' && mat[x, y - 1] != '.' && mat[x, y + 1] != '.'
                && mat[x, y + 1] != '.' && mat[x + 1, y - 1] != '.' && mat[x + 1, y] != '.' && mat[x + 1, y + 1] != '.')
                Console.WriteLine("yes");
            else
            {
                Console.WriteLine("no");
            }
            
            

            
        }
    }
}
