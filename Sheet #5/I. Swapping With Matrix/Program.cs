using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Swapping_With_Matrix
{
    internal class Program
    {
        static void MatrixSwapping(int[,] matrix,int n, int x, int y)
        {
            for(int i = 0; i < n; i++)
            {
                int temp = matrix[x,i];
                matrix[x, i] = matrix[y,i];
                matrix[y, i] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, x];
                matrix[i, x] = matrix[i, y];
                matrix[i, y] = temp;
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string [] nums= Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int x = int.Parse(nums[1]);
            int y = int.Parse(nums[2]);
            x--;
            y--;

            int [,] matrix = new int[n, n];

            for( int i = 0; i < n;i++)
            {
                string[] items = Console.ReadLine().Split();
                for ( int j = 0; j < n;j++)
                {
                    matrix[i, j] = int.Parse(items[j]);
                }
            }

            MatrixSwapping(matrix,n,x,y);
        }
    }
}
