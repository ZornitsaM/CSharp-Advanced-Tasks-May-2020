using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var fromTo = Console.ReadLine().Split().Select(int.Parse).ToList();
            var results = new List<int>();

            for (int i = fromTo[0]; i <= fromTo[1]; i++)
            {
                results.Add(i);
            }

            Predicate<int> isEven = number => number % 2 == 0;
            string command = Console.ReadLine();

            if (command == "even")
            {
                results = results.FindAll(isEven).ToList();

                foreach (var item in results)
                {
                    Console.Write(item + " ");
                }
            }

            else if (command == "odd")
            {
                results = results.FindAll(number => !isEven(number)).ToList();

                foreach (var item in results)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
