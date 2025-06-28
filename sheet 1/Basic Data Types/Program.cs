using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a=int.Parse(Console.ReadLine());
            long b=long.Parse(Console.ReadLine());
            char c= char.Parse(Console.ReadLine());
            float d= float.Parse(Console.ReadLine());
            double e= double.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);*/

            Console.WriteLine("enter values seprated by space ' ' ");

            string values = Console.ReadLine();

            var seperatedValues = values.Split(' ');

            foreach (var item in seperatedValues)
            {
                Console.WriteLine(item);
            }



        }
    }
}
