using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Reverse();
            var stack = new Stack<string>(input);
            int sum = 0;

            while (stack.Count>1)
            {
                int finalNumber=int.Parse(stack.Pop());
                var symbol = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                if (symbol=="+")
                {
                    sum = finalNumber + secondNumber;
                }
                else
                {
                    sum = finalNumber - secondNumber;
                }

                stack.Push(sum.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
