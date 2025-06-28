using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.First_digit__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int firstNum = int.Parse(num.Substring(0,1));

            if(firstNum % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
        }
    }
}
