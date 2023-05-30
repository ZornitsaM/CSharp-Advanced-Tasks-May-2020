using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var queue = new Queue<string>();
            int count = 0;

            while (command! = "End")
            {
                if (command == "Paid")
                {
                    while (queue.Any())
                    {
                        string currentName = queue.Dequeue();
                        Console.WriteLine(currentName);
                    }
                    count = 0;
                }
                else
                {
                    queue.Enqueue(command);
                    count++;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} people remaining.");
        }
    }
}
