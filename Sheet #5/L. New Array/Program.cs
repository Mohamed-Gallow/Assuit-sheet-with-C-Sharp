using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.New_Array
{
    internal class Program
    {
        static void Concat(string[] a, string[] b)
        {
            for(int i = 0; i < b.Length;i++)
            {
                Console.Write(b[i] + " ");
            }
            for(int i=0; i < a.Length;i++)
            {
                if(i == a.Length-1)
                    Console.Write(a[i]);
                else
                    Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = Console.ReadLine().Split();
            string[] b = Console.ReadLine().Split();
            Concat(a, b);
        }
    }
}
