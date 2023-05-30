using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    stack.Push(i);
                }
                else if (input[i]==')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string output = input.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(output);

                }
            }
        }
    }
}
