using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Even_Hate_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while(t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (n % 2 != 0)
                    Console.WriteLine(-1);
                else
                {
                    int even = 0;
                    int odd = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (array[i] %2 == 0)
                            even++;
                        else
                            odd++;
                    }
                    if(even == odd)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine((Math.Max(even,odd) - Math.Min(even,odd))/2);
                }
                
                t--;
            }
        }
    }
}
