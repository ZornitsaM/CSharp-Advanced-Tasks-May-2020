using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ");
            var queue = new Queue<string>(songs);
            string command = Console.ReadLine();

            while (queue.Any())
            {
                var commandArray = command.Split();

                if (command=="Play")
                {
                    if (queue.Count==0)
                    {
                        Console.WriteLine("No more songs!");
                    }
                    else
                    {
                        queue.Dequeue();
                    }
                }
                else if (commandArray[0]=="Add")
                {
                    string song = string.Empty;

                    for (int i = 1; i <= commandArray.Length; i++)
                    {
                        if (i==commandArray.Length-1)
                        {
                            song += commandArray[i];
                            break;
                        }
                        song += commandArray[i];
                        song += " ";
                    }

                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command=="Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                command = Console.ReadLine();
            }

            if (queue.Count==0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
