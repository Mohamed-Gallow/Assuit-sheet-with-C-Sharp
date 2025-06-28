using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Convert_To_Decimal_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int p=0;
                double sum = 0;
                while (n > 0)
                {
                    int x = n % 2;
                    n /= 2;
                    if(x==1)
                    {
                        sum +=Math.Pow(2,p);
                        p++; 
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
