using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class StringCompression
    {

        static void Main(string[] args)
        {
            string str = "aaabbccc";
            string op = "";
            int cnt = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    cnt++;
                }
                else
                {
                    op += str[i - 1] + cnt.ToString();
                    cnt = 1;
                }
            }

            // Append the last character and its count
            op += str[str.Length - 1] + cnt.ToString();

            Console.WriteLine(op);
            Console.ReadLine();
        }

    }
}
