using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Print_from_N_to_1
{
    internal class Program
    {
        static void print(int n)
        {
            if (n == 0)
                return;
            if(n == 1)
                Console.Write(n);
            else
                Console.Write(n + " ");
            print(n - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            print(n);
        }
    }
}
