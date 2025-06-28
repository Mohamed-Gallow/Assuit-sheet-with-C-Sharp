using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Next_Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c =char.Parse(Console.ReadLine());

            if(c != 'z')
            {
                Console.WriteLine((char)(c+1));
            }
            else if(c == 'z')
            {
                Console.WriteLine((char)(c -25));
            }
        }
    }
}
