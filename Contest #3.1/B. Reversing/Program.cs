using System;

namespace B.Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number of elements
            int n = int.Parse(Console.ReadLine());
            // Read the array elements
            string[] arrStr = Console.ReadLine().Split();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }

            // Process the array
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    ReverseArray(arr, 0, i - 1);
                }
            }

            // Print the final array
            Console.WriteLine(string.Join(" ", arr));
        }

        // Helper function to reverse a portion of the array
        static void ReverseArray(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
