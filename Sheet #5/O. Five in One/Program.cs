using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Five_in_One
{
    internal class Program
    {
        static int MaxNum(int[] arr)
        {
            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > temp)
                    temp = arr[i];
            }
            return temp;
        }

        static int MinNum(int[] arr)
        {
            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < temp)
                    temp = arr[i];
            }
            return temp;
        }

        static int CountPrime(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= 1)
                    continue;

                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(arr[i]); j++)
                {
                    if (arr[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    counter++;
            }
            return counter;
        }

        static int CountPalindrome(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string temp = arr[i].ToString();
                bool isPalindrome = true;
                for (int j = 0; j < temp.Length / 2; j++)
                {
                    if (temp[j] != temp[temp.Length - 1 - j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                    counter++;
            }
            return counter;
        }

        static int HasMaxDivisor(int[] arr)
        {
            int maxDivisors = 0;
            int item = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                int countDivisors = 0;
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                        countDivisors++;
                }
                if (countDivisors > maxDivisors || (countDivisors == maxDivisors && arr[i] > item))
                {
                    item = arr[i];
                    maxDivisors = countDivisors;
                }
            }
            return item;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }

            Console.WriteLine("The maximum number : " + MaxNum(arr));
            Console.WriteLine("The minimum number : " + MinNum(arr));
            Console.WriteLine("The number of prime numbers : " + CountPrime(arr));
            Console.WriteLine("The number of palindrome numbers : " + CountPalindrome(arr));
            Console.WriteLine("The number that has the maximum number of divisors : " + HasMaxDivisor(arr));
        }
    }
}

