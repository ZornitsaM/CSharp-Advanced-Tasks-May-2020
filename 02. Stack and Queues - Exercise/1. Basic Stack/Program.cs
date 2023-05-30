using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int pushNumber = commandNumbers[0];
            int popNumber = commandNumbers[1];
            int checkNumber = commandNumbers[2];

            var stack = new Stack<int>();

            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i <pushNumber; i++)
            {
                stack.Push(inputNumbers[i]);
            }

            for (int i = 0; i < popNumber; i++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (stack.Contains(checkNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
