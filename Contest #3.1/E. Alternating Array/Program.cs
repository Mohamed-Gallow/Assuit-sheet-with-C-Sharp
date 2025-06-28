using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Alternating_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

            int changePattern1 = 0;
            int changePattern2 = 0;
            for (int i = 0; i < n; i++)
            {
                if(i%2 == 0)
                {
                    if (arr[i] < 0)
                        changePattern1++;
                    if(arr[i] > 0)
                        changePattern2++;
                }
                else
                {
                    if(arr[i] > 0)
                        changePattern1++;
                    if(arr[i] < 0)
                        changePattern2++;
                }
            }
            int result = Math.Min(changePattern1, changePattern2);
            Console.WriteLine(result);
        }
    }
}
