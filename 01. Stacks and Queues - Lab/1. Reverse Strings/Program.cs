using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            foreach (var item in stack)
            {
                Console.Write(item);
            }
        }
    }
}
