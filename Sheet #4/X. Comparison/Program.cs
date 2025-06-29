using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string sub1, sub2;
            string newString, result= s;
            
            for(int i=0; i < s.Length-1;i++)
            {
                sub1 = s.Substring(0,i+1);
                sub2 = s.Substring(i+1);

                char[] arr1 = sub1.ToCharArray();
                char[] arr2 = sub2.ToCharArray();

                Array.Sort(arr1);
                Array.Sort(arr2);

                string sorted1 = new string(arr1);
                string sorted2 = new string(arr2);

                newString = sorted1+sorted2;
                if (String.Compare(newString, result) < 0)
                {
                    result = newString;
                }

            }
            Console.WriteLine(result);
        }
    }
}
