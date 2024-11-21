using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class FindDuplicate_Missing_Number
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 3, 6, 2, 1, 1, 6, 7, 9, 9 }; // Example array

            FindMissingAndDuplicateNumbers(arr);

            Console.ReadLine();
        }

        static void FindMissingAndDuplicateNumbers(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("No elements in the array.");
                return;
            }

            int maxNumber = arr[0];
            int minNumber = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber)
                    maxNumber = arr[i];
                if (arr[i] < minNumber)
                    minNumber = arr[i];
            }

            int[] count = new int[maxNumber - minNumber + 1];//9-1+1=9
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - minNumber]++;
            }

            Console.Write("Duplicate numbers: ");
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 1)
                {
                    Console.Write(i + minNumber + " ");
                }
            }
            Console.WriteLine();

            Console.Write("Missing numbers: ");
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == 0)
                {
                    Console.Write(i + minNumber + " ");
                }
            }
            Console.WriteLine();
        }
    }

}

