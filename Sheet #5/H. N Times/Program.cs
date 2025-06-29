using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.N_Times
{
    internal class Program
    {
        static void Times(int n, char c)
        {
            for(int i = 0; i < n; i++)
            {
                if(i == n-1)
                    Console.WriteLine(c);
                else
                    Console.Write(c+" ");
            }
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] arr = Console.ReadLine().Split();
                int n = int.Parse(arr[0]);
                char c = char.Parse(arr[1]);
                Times(n, c);
                t--;
            }
        }
    }
}
