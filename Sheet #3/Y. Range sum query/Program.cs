using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split();
        int n = int.Parse(nums[0]); // Size of the array
        int q = int.Parse(nums[1]); // Number of queries

        string[] arr = Console.ReadLine().Split();
        long[] prefixSum = new long[n + 1]; // Array to store prefix sums

        // Calculate prefix sums
        for (int i = 1; i <= n; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + int.Parse(arr[i - 1]);
        }

        // Process queries
        while (q > 0)
        {
            string[] range = Console.ReadLine().Split();
            int l = int.Parse(range[0]);
            int r = int.Parse(range[1]);

            // Calculate sum within the range using prefix sums
            long sum = prefixSum[r] - prefixSum[l - 1];

            Console.WriteLine(sum);

            q--;
        }
    }
}
