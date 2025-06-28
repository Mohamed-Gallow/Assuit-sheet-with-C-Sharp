using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.Coordinates_of_a_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums=Console.ReadLine().Split();
            double x=double.Parse(nums[0]);
            double y=double.Parse(nums[1]);

            if(x >0 && y >0)
            {
                Console.WriteLine("Q1");
            }
            else if(x <0 && y>0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }

        }
    }
}
