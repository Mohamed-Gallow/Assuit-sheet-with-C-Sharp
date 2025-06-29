using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for(int i =0; i < s.Length; i++)
            {
                if (s[i] == ',')
                    result.Append(' ');
                else if (char.IsLower(s[i]))
                    result.Append(char.ToUpper(s[i]));
                else if (char.IsUpper(s[i]))
                    result.Append(char.ToLower(s[i]));  
                else
                    result.Append(s[i]);
            }
            Console.WriteLine(result);
        }
    }
}
