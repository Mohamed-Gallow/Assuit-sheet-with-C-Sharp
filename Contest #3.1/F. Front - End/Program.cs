using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Front___End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                    Console.Write(array[i] + " " + array[n - i - 1] + " ");
            }
            else
            {
                for (int i = 0;i < (n / 2)+1; i++)
                {
                    if (i == n / 2)
                        Console.Write(array[i]);
                    else
                        Console.Write(array[i] + " " + array[n - i - 1] + " ");
                }
            }
        }
    }
}
