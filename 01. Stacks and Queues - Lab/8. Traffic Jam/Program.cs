using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {

            int greenPassedCars = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();
            int countPassed = 0;

            string command = Console.ReadLine();

            while (command!="end")
            {
                if (command=="green")
                {
                    for (int i = 0; i < greenPassedCars; i++)
                    {
                        if (queue.Any())
                        {
                            string currentPassCar = queue.Dequeue();
                            Console.WriteLine($"{currentPassCar} passed!");
                            countPassed++;
                        }
                    }
                }

                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{countPassed} cars passed the crossroads.");
        }
    }
}
