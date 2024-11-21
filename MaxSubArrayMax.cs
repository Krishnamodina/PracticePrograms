using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class MaxSubArrayMax
    {
        static void Main()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            int maxSum = nums[0]; // Initialize maxSum with the first element of the array
            int currentSum = 0;
            int i1= 0;
            int i2= 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                // Update currentSum: either extend the current subarray or start a new one
                if (num > currentSum + num)
                {
                    currentSum = num;
                    i1 = i;
                }
                else
                    currentSum = currentSum + num;

                // Update maxSum if currentSum becomes greater
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    i2= i;
                }
            }


            Console.Write("Maximum Subarray Sum: " + maxSum);  // Output: 6
            
            for(int i=i1;i<=i2;i++)
            {
                Console.Write(nums[i]);
            }
            Console.Write("indices are " + i1 + "," + i2);

            Console.ReadLine();
        }


    }

}