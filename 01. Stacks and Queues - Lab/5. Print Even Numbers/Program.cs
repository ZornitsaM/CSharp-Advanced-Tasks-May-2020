using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var queue = new Queue<int>();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i]%2==0)
                {
                    queue.Enqueue(inputNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
