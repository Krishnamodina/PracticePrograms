using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class LeftRotation
    {
        static void Main(string[]args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5};
            int steps =3;  // Number of steps to rotate left
            int len = arr.Length;

            // Normalize the steps to ensure they are within the array bounds
            steps = steps % len;
            if (steps < 0)
            {
                steps += len;
            }

            // Rotate the array by N steps
            int[] tempArr = new int[len];
            for (int i = 0; i < len; i++)
            {
                tempArr[i] = arr[(i + steps) % len];
            }

            // Copy the rotated array back to the original array
            for (int i = 0; i < len; i++)
            {
                arr[i] = tempArr[i];
            }

            // Print the rotated array
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
