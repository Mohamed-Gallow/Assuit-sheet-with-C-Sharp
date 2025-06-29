using System;

namespace P.Count_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine(0);
                return;
            }

            int count = 0;
            bool inWord = false;

            for(int i = 0; i < s.Length; i++)
            {
                if(char.IsLetter(s[i]))
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                    inWord = false;

            }

            Console.WriteLine(count);
        }
    }
}
