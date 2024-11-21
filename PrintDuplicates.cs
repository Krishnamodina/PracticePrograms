using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class PrintDuplicates
    {
        static void Main(string[]args)
        {
            
            int[] arr =
            {
              4,6,8,9,1,2,4,5,7,8,1 
            };
            int[] d = new int[arr.Length];
            Console.Write("Unique Elements");
            for (int i=0;i<arr.Length;i++)
            {
                bool isDuplicate = false;
                for (int j=i+1;j<arr.Length;j++)
                {
                   
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        d[i] = arr[i];
                        break;
                    }
                }
                
                if (!isDuplicate)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.Write("\nDuplicate Numbers");
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] != 0)
                    Console.Write(d[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
