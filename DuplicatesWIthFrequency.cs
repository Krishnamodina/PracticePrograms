using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class DuplicatesWIthFrequency
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 2, 6, 7, 5, 7, 4, 6, 8, 9, 1, 2 };
            FindAndPrintDuplicatesWithFrequency(arr);

            Console.ReadLine();
        }

        static void FindAndPrintDuplicatesWithFrequency(int[] arr)
        {
            int n = arr.Length;
            int[] frequency = new int[n];

            // Initialize the frequency array with zeros
            for (int i = 0; i < n; i++)
            {
                frequency[i] = 0;
            }

            // Count frequencies of each element
            for (int i = 0; i < n; i++)
            {
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j] )
                    {
                        count++;
                        frequency[j] = -1; // Mark as visited by setting it to a value
                                           // outside the range
                    }
                }
                if (frequency[i] != -1)
                {
                    frequency[i] = count;
                }
            }

            // Print duplicate elements and their frequencies
            Console.WriteLine("Duplicate Numbers and their frequencies:");
            for (int i = 0; i < n; i++)
            {
                if (frequency[i] >1)
                {
                    Console.WriteLine(arr[i] + " appears " + frequency[i] + " times");
                }
            }
        }

    }

}
