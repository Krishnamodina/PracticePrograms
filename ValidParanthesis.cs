using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class ValidParanthesis
    {
        static void Main(string[] args)
        {
            string str = "{[()]";
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0 || (c == ')' && stack.Pop() != '(') ||
                        (c == ']' && stack.Pop() != '[') ||
                        (c == '}' && stack.Pop() != '{'))
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadLine();
        }

    }
}
