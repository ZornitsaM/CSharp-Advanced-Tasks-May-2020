using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pumps = new Queue<int[]>();
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                var currPump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(currPump);
            }

            while (true)
            {
                int fuelAmount = 0;
                bool foundPoint = true;

                for (int i = 0; i < n; i++)
                {
                    var currentPump = pumps.Dequeue();
                    fuelAmount += currentPump[0];

                    if (fuelAmount < currentPump[1])
                    {
                        foundPoint = false;
                    }

                    fuelAmount -= currentPump[1];
                    pumps.Enqueue(currentPump);
                }

                if (foundPoint)
                {
                    break;
                }

                cnt++;

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(cnt);
        }
    }
}
