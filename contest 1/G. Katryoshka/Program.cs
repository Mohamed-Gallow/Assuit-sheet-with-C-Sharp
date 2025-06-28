using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Katryoshka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            long n = long.Parse(nums[0]);
            long m = long.Parse(nums[1]);
            long k = long.Parse(nums[2]);
            
            long res = minmum(n,m,k);

            n -= res;
            m -= res;
            k -= res;

            long mn = Math.Min(n / 2, k);
            res +=mn;

            Console.WriteLine(res);
            

            



            /*
             * my solution with wrong answer in test case 9
             * if(n!=0 && m!=0 && k!=0)
            {
                res = minmum(n,m,k);
                n -= minmum(n, m, k);
                m -= minmum(n, m, k);
                k -= minmum(n, m, k);
                if(n != 0 && k!=0)
                {
                    if (n / 2 <= k)
                        res += n / 2;
                    else
                        res += k;
                }
            }
            else if(n != 0 && m==0 && k != 0)
            {
                if (n / 2 <= k)
                    res += n / 2;
                else
                    res += k;
            }
            else if (n == 0 || k == 0)
            {
                res = 0;
            }
            Console.WriteLine(res);
            */

        }
        static long minmum(long x, long y, long z)
        {
            if (x >= y && y >= z)
                return z;
            else if(x >= y && z >= y)
                return y;
            else
                return x;

        }
    }
}
