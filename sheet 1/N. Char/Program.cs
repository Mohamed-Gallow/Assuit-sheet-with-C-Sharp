using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N.Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x= char.Parse(Console.ReadLine());

            if(x>=97 && x<=122)
            {
                Console.WriteLine((char)(x - 32));
            }

            if (x >= 65 && x <= 90)
            {
                Console.WriteLine((char)(x + 32));
            }
        }
    }
}
