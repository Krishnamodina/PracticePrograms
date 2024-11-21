using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class StringWordReverse
    {
        static void Main(string[] args)
        {               //0123456789
            string str = "This is My Name";
            ReverseWordsInString(str);
            Console.ReadLine();
        }

        static void ReverseWordsInString(string str)
        {
            int start = str.Length - 1;
            for (int end = str.Length - 1; end >= 0; end--)
            {
                if (str[end] == ' ')
                {
                    for (int i = end + 1; i <= start; i++)
                    {
                        Console.Write(str[i]);
                    }
                    Console.Write(" ");
                    start = end - 1;
                }
            }

            // Print the first word
            for (int i = 0; i <= start; i++)
            {
                Console.Write(str[i]);
            } 
        }

    }
}
