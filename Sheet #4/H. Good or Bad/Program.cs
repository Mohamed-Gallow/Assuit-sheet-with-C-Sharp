using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Good_or_Bad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while(t > 0)
            {
                string s = Console.ReadLine();
                /*bool isGood = false;
                for (int i = 0; i <= s.Length-3; i++)
                {
                    if (s.Substring(i, 3) == "010" || s.Substring(i, 3) == "101")
                    {
                        isGood = true;
                        break;
                    }
                }
                if (isGood)
                    Console.WriteLine("Good");
                else
                    Console.WriteLine("Bad");
                */
                if (s.Contains("101") == true || s.Contains("010") == true)
                    Console.WriteLine("Good");
                else
                    Console.WriteLine("Bad");
                t--;
            }
        }
    }
}
