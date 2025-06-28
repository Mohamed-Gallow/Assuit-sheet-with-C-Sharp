using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Capital_or_Small_or_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x= char.Parse(Console.ReadLine());

            if (x >= 48 && x <= 57) 
            Console.WriteLine("IS DIGIT");

            if (x >= 97 && x <= 122) 
            Console.WriteLine("ALPHA\nIS SMALL");

            if (x >= 65 && x <= 90) 
            Console.WriteLine("ALPHA\nIS CAPITAL");
        }
    }
}
