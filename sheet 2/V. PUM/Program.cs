using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.PUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine(count+" "+(++count)+" "+(++count)+ " PUM");
                count++;
                count++;

            }
        }
    }
}
