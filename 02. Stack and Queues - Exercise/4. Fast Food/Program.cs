using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantutyForDay = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(orders);
            int maxValueOrders = queue.Max();

            while (queue.Any())
            {
                int currentOrder = queue.Peek();

                if (quantutyForDay - currentOrder < 0)
                {
                    break;
                }

                else 
                {
                    quantutyForDay -= currentOrder;
                    queue.Dequeue();
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(maxValueOrders);
                Console.WriteLine("Orders complete");
            }

            else if (queue.Count > 0)
            {
                Console.WriteLine(maxValueOrders);
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
