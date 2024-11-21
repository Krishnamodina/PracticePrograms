
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class MergeSortedArrays
    {
        static void Main(string[] args)
        {
            int index1=0,index2=0;
            int[] arr1 = { 1, 4, 7, 19, 21,79,103};
            int[] arr2 = { 2, 4, 7, 9, 13,78};
            
            int[] arr3 = new int[arr1.Length + arr2.Length];
            for(int i=0;i<arr3.Length;i++)
            {
                if (index1 < arr1.Length && (index2 >= arr2.Length ||arr1 [index1] <= arr2[index2]))
                {
                    arr3[i] = arr1[index1];
                    index1++;
                }
                else
                {
                    if (index2 < arr2.Length)
                    {
                        arr3[i] = arr2[index2];
                        index2++;
                    }
                }
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]+",");
            }
            Console.ReadLine();
        }
    }
}