using System;
using System.Linq;
using System.Text;

namespace L.String_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int Q = int.Parse(inputs[1]);

            StringBuilder s = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < Q; i++)
            {
                string[] query = Console.ReadLine().Split();
                string command = query[0];

                switch (command)
                {
                    case "pop_back":
                        if (s.Length > 0)
                        {
                            s.Remove(s.Length - 1, 1);
                        }
                        break;

                    case "front":
                        if (s.Length > 0)
                        {
                            Console.WriteLine(s[0]);
                        }
                        break;

                    case "back":
                        if (s.Length > 0)
                        {
                            Console.WriteLine(s[s.Length - 1]);
                        }
                        break;

                    case "sort":
                        {
                            int l = int.Parse(query[1]) - 1;
                            int r = int.Parse(query[2]) - 1;
                            if (l >= 0 && r < s.Length)
                            {
                                int start = Math.Min(l, r);
                                int end = Math.Max(l, r);
                                var sortedSubstr = s.ToString().Substring(start, end - start + 1).OrderBy(c => c).ToArray();
                                s.Remove(start, end - start + 1);
                                s.Insert(start, new string(sortedSubstr));
                            }
                        }
                        break;

                    case "reverse":
                        {
                            int l = int.Parse(query[1]) - 1;
                            int r = int.Parse(query[2]) - 1;
                            if (l >= 0 && r < s.Length)
                            {
                                int start = Math.Min(l, r);
                                int end = Math.Max(l, r);
                                var reverseSubstr = s.ToString().Substring(start, end - start + 1).ToCharArray();
                                Array.Reverse(reverseSubstr);
                                s.Remove(start, end - start + 1);
                                s.Insert(start, new string(reverseSubstr));
                            }
                        }
                        break;

                    case "print":
                        {
                            int pos = int.Parse(query[1]) - 1;
                            if (pos >= 0 && pos < s.Length)
                            {
                                Console.WriteLine(s[pos]);
                            }
                        }
                        break;

                    case "substr":
                        {
                            int l = int.Parse(query[1]) - 1;
                            int r = int.Parse(query[2]) - 1;
                            if (l >= 0 && r < s.Length)
                            {
                                int start = Math.Min(l, r);
                                int end = Math.Max(l, r);
                                Console.WriteLine(s.ToString().Substring(start, end - start + 1));
                            }
                        }
                        break;

                    case "push_back":
                        s.Append(query[1]);
                        break;
                }
            }
        }
    }
}
