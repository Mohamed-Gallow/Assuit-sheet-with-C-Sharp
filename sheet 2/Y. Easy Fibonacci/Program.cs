using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y.Easy_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine(0);
            else
            {
                int a = 0, b = 1;
                Console.Write(a + " " + b);
                for (int i = 2; i < n; i++)
                {
                    int c = a + b;
                    Console.Write(" " + c);
                    a = b;
                    b = c;
                }
            }
        }
    }
}
