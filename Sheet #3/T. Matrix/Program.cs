using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int mainDiag = 0, seconedDiag = 0;


            for (int i = 0; i < n; i++)
            {
                string[] items = Console.ReadLine().Split();
                for(int j = 0; j < n; j++)
                {
                    matrix[i,j] = Convert.ToInt32(items[j]);
                    if(i == j)
                        mainDiag += matrix[i,j];
                    if(i+j == n-1)
                        seconedDiag += matrix[i,j];
                }
            }
            Console.WriteLine(Math.Abs(mainDiag - seconedDiag));
            /* //another solution
            int x = 0;
            int y = n-1;
            int mainDiag = 0;
            int seconedDiag = 0;
            for(int i = 0;i < n; i++)
            {
                mainDiag += matrix[i,x];
                x++;
                seconedDiag += matrix[i,y];
                y--;
            }
            Console.WriteLine(Math.Abs(mainDiag-seconedDiag));
            */
        }
    }
}
