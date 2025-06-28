using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Fixed_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                int password = int.Parse(Console.ReadLine());
                if(password != 1999)
                {
                    Console.WriteLine("Wrong");
                }
                else
                {
                    Console.WriteLine("Correct");
                    break;

                }
            }
         

        }
    }
}
