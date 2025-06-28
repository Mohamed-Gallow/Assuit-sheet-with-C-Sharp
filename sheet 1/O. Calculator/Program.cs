using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string equ = Console.ReadLine();
            int indxOfOpreator=0;
            char opreator=' ';
            for(int i=0; i<equ.Length; i++)
            {
                if(equ[i] =='+' || equ[i] =='-' || equ[i] == '*' || equ[i] == '/')
                {
                    indxOfOpreator = i;
                    opreator = equ[i];
                    break;
                }
            }
            int num1=int.Parse(equ.Substring(0,indxOfOpreator));
            int num2=int.Parse(equ.Substring(indxOfOpreator+1));

            switch(opreator)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
            }
            
            
            
        }
    }
}
