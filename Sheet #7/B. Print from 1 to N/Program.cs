using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Print_from_1_to_N
{
    internal class Program
    {
        static void print(int current, int n)
        {
            if (current> n)
                return;
            Console.WriteLine(current);
            print(current+1,n);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            print(1,n);
        }
    }
}
