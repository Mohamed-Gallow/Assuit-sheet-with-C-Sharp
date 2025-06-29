using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Let_s_use_Getline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int indx = s.IndexOf('\\');
            Console.WriteLine(s.Substring(0,indx));
        }
    }
}
