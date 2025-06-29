using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Print_Digits_using_Recursion
{
    internal class Program
    {
        static void print(int n)
        {
            if(n == 0)
                return;

            print(n / 10);
            Console.Write((n%10)+" ");
            
        }
        static void Main(string[] args)
        {
            int t  = int.Parse(Console.ReadLine());
            while(t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                    Console.WriteLine(0);
                else
                {
                    print(n);
                    Console.WriteLine();
                }
                
                t--;
            }
            
        }
    }
}
