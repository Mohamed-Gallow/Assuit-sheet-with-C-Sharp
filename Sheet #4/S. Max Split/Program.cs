using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Max_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            List<string> list = new List<string>();
            int count = 0;
            int balance = 0;
            int startIndx = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == 'L')
                    count++;
                else if(s[i] == 'R')
                    count--;

                if(count == 0)
                {
                    balance++;
                    list.Add(s.Substring(startIndx,i-startIndx+1));
                    startIndx = i+1;
                }
            }
            Console.WriteLine(balance);
            foreach (string bal in list)
                Console.WriteLine(bal);


        }
    }
}
