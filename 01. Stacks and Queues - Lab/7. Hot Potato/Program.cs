using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputPlayers = Console.ReadLine().Split();
            var queue = new Queue<string>(inputPlayers);
            int count = int.Parse(Console.ReadLine());

            while (queue.Any())
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                string removedPLayer = queue.Dequeue();

                if (queue.Count==0)
                {
                    Console.WriteLine($"Last is {removedPLayer}");
                }

                else
                {
                    Console.WriteLine($"Removed {removedPLayer}");
                }
            }
        }
    }
}
