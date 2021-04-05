using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (nums[0] == 1)
                {
                    stack.Push(nums[1]);
                }

                else if (nums[0] == 2)
                {
                    stack.Pop();
                }

                else if (nums[0]==3)
                {
                    if (stack.Any())
                    {
                        int max = stack.Max();
                        Console.WriteLine(max);
                    }
                }

                else if (nums[0] == 4)
                {
                    if (stack.Any())
                    {
                        int min = stack.Min();
                        Console.WriteLine(min);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
