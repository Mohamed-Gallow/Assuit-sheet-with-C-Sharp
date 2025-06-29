using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x =Console.ReadLine();
            string y =Console.ReadLine();

            for(int i =0; i < Math.Min(x.Length,y.Length); i++)
            {
                if (x[i] < y[i])
                {
                    Console.WriteLine(x);
                    return;
                }
                else if (x[i] > y[i])
                {
                    Console.WriteLine(y);
                    return;
                }
            }
            // If all characters so far are equal, the shorter string is lexicographically smaller
            if (x.Length < y.Length)
            {
                Console.WriteLine(x);
            }
            else if (x.Length > y.Length)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(x); // or Console.WriteLine(y), as they are equal
            }
        }
    }
}
