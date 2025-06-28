using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.Float_or_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number=Console.ReadLine();
            int intNum = 0;
            int floatNum = 0;

            for(int i=0; i<number.Length; i++)
            {
                if(number[i] =='.')
                {                  
                    intNum = int.Parse(number.Substring(0, i));
                    floatNum = int.Parse(number.Substring(i+1));
                    break;
                }
            }

            if(floatNum == 0)
            {
                Console.WriteLine("int "+intNum);
            }
            else
            {
                Console.WriteLine("float "+intNum+" 0."+floatNum);
            }

        }
    }
}
