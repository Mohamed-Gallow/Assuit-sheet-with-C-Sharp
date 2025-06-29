using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.WriteLine(a.Length+" "+b.Length);
            Console.WriteLine(a+b);

            char c = a[0];
            a = b[0] + a.Substring(1);
            b = c + b.Substring(1);

            Console.WriteLine(a+" "+b);
        }
    }
}
