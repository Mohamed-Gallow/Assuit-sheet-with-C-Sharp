using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int n = int.Parse(Console.ReadLine());
            int nSaver = n;
            string res = "";
            while(n > 0)
            {
                int k = n % 10;
                n = n / 10;
                res = res + k.ToString();

            }
            int nReverse=int.Parse(res);
            Console.WriteLine(nReverse);
            if (nSaver == nReverse)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            */

            // another solution

            int n, temp, rev = 0;
            n=int.Parse(Console.ReadLine());
            temp = n;

            while(n > 0)
            {
                rev = rev * 10 + n % 10; // rev*10 => علشان اتحرك بمقدار رقم n%10 => علشان اجيب اخر رقم واحطه في الاول
                n /= 10;
            }
            if (temp == rev)
                Console.WriteLine(rev + "\nYES");
            else
                Console.WriteLine(rev + "\nNO");
            
            
        }
    }
}
