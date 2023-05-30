using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);

            var command = Console.ReadLine().Split().ToArray();

            while (command[0].ToLower() != "end")
            {
                if (command[0].ToLower() == "add")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        int inputNumber = int.Parse(command[i]);
                        stack.Push(inputNumber);
                    }
                }
                else if (command[0].ToLower() == "remove")
                {
                    int inputNumber = int.Parse(command[1]);

                    if (inputNumber<stack.Count)
                    {
                        for (int i = 0; i < inputNumber; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }

            int output = 0;

            foreach (var item in stack)
            {
                output += item;
            }

            Console.WriteLine($"Sum: {output}");
        }
    }
}
