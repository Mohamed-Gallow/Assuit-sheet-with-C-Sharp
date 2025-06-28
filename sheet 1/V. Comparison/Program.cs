using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();
            int a = int.Parse(elements[0]);
            char s =char.Parse(elements[1]);
            int b =int.Parse(elements[2]);

            switch (s)
            {
                case '>':
                    Console.WriteLine((a > b) ? "Right" : "Wrong");
                    break;
                case '<':
                    Console.WriteLine((a < b) ? "Right" : "Wrong");
                    break;
                case '=':
                    Console.WriteLine((a == b) ? "Right" : "Wrong");
                    break;

            }

        }
    }
}
