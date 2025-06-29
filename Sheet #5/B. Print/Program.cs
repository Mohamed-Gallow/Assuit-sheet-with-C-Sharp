using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Print
{
    internal class Program
    {
        static void print(int n)
        {
            for(int i = 1; i < n; i++)
                Console.Write(i+" ");
            Console.WriteLine(n);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            print(n);
        }
    }
}
