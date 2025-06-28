using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.Age_in_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int years = n / 365;
            int months = (n - (years * 365)) / 30;
            Console.WriteLine(years + " years");
            Console.WriteLine(months + " months");
            Console.WriteLine(n-((years*365)+(months*30)) + " days");
        }
    }
}
