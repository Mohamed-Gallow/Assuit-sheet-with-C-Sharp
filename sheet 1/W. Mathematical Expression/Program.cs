using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W.Mathematical_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();
            int a = int.Parse(elements[0]);
            char s = char.Parse(elements[1]);
            int b = int.Parse(elements[2]);
            char q = char.Parse(elements[3]);
            int c = int.Parse(elements[4]);

            switch (s)
            {
                case '+':
                    if ((a + b) == c)
                        Console.WriteLine("Yes");
                    else
                        Console.WriteLine(a + b);
                    break;
                case '-':
                    if ((a - b) == c)
                        Console.WriteLine("Yes");
                    else
                        Console.WriteLine(a - b);
                    break;
                case '*':
                    if ((a * b) == c)
                        Console.WriteLine("Yes");
                    else
                        Console.WriteLine(a * b);
                    break;
            }
        }
    }
}
