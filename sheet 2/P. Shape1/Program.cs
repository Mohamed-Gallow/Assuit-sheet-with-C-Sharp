using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Shape1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i > 0; i--)
            {
                for(int j = i; j >0; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
