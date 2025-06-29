using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Wonderful_Number
{
    internal class Program
    {
        static bool IsEven(int n)
        {
            if(n % 2 == 0)
                return true;
            else
                return false;
        }

        static bool Binary(int n)
        {
            int mod;
            StringBuilder s1 = new StringBuilder();
            StringBuilder s2 = new StringBuilder();
            while(n > 0)
            {
                mod = n % 2;
                n=n/2;
                if (mod == 0)
                    s1.Append("0");
                else
                    s1.Append("1");
            }
            for(int i = s1.Length-1; i >= 0; i--)
            {
                s2.Append(s1[i]);
            }
            if (s1.ToString() == s2.ToString())
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (IsEven(n))
                Console.WriteLine("NO");
            else
            {
                if (Binary(n))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
