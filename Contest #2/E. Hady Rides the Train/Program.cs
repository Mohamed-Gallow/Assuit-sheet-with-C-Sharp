using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Hady_Rides_the_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n =long.Parse(Console.ReadLine());
            long row = n/4;
            long column;
            if(row %2 == 0)
            {
                column = n%4;
            }
            else
            {
                column=3-(n%4);
            }
            
            Console.WriteLine(row + " " + column);
        }
    }
}
