using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Shape2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for(int j =0; j < n-i; j++)
                    Console.Write(" ");
                for(int k = 0; k < (i*2)-1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
            
        }
    }
}
