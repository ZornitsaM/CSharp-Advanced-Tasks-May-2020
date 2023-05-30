using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int sumForOneBox = 0;
            int countBox = 1;

            var stack = new Stack<int>(numbers);

            while (stack.Any())
            {
                int currentNumber = stack.Peek();

                sumForOneBox += currentNumber;

                if (sumForOneBox<capacity)
                {
                    stack.Pop();
                }

                else if(sumForOneBox==capacity)
                {
                    stack.Pop();
                    if (stack.Any())
                    {
                        countBox++;
                        sumForOneBox = 0;
                    }
                }
                else
                {
                    countBox++;
                    sumForOneBox = 0;
                }
            }
            Console.WriteLine(countBox);
        }
    }
}
