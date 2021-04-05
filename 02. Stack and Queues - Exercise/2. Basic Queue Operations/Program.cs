using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            var commandNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int pushNum = commandNumbers[0];
            int popNum = commandNumbers[1];
            int checkNum = commandNumbers[2];

            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < pushNum; i++)
            {
                queue.Enqueue(inputNumbers[i]);
            }

            for (int i = 0; i < popNum; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count==0)
            {
                Console.WriteLine("0");
            }

            else if (queue.Contains(checkNum))
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
