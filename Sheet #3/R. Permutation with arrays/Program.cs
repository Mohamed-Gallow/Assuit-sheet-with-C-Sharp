using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.Permutation_with_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = Console.ReadLine().Split();
            string[] b = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(a[i]);
            }
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(b[i]);
            }
            Array.Sort(a);
            Array.Sort(b);
            

            int flag=0;
            for (int i = 0; i < n;i++)
            {
                if(a[i] != b[i])
                {
                    flag++;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

        }
    }
}
