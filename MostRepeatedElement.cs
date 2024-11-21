using System;

namespace PracticePrograms
{
    internal class MostRepeatedElement
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 3, 4, 2, 4, 4, 4, 5, 3, 2,2, 6, 7 };
            int[] B = new int[A.Length];

            // Initialize the count array B
            for (int i = 0; i < B.Length; i++)
                B[i] = 0;

            // Count occurrences of each element
            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == -1) continue; // Skip if already marked

                int cnt = 1;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        cnt++;
                        B[j] = -1; // Mark as counted
                    }
                }
                B[i] = cnt;
            }

            // Find the maximum count
            int maxCount = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] > maxCount)
                {
                    maxCount = B[i];
                }
            }

            // Collect all elements with the maximum count
            Console.WriteLine($"Elements with the maximum count ({maxCount} occurrences):");
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == maxCount)
                {
                    Console.WriteLine(A[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
