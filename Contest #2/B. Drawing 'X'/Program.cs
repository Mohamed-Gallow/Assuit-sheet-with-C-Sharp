using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Drawing__X_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n;i++)
            {
                
                for(int j = 0; j < n;j++)
                {
                    if (i == n / 2 && j == n / 2)
                        Console.Write("X");
                    else if (j == i)
                        Console.Write("\\");
                    else if(j==(n-i)-1)
                        Console.Write("/");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
