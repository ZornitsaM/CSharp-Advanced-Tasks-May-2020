using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstCollection = inputNumbers[0];
            int secondSelection = inputNumbers[1];

            var firstSet = new HashSet<int>();
            var finalSet = new HashSet<int>();

            for (int i = 0; i < firstCollection; i++)
            {
                int input = int.Parse(Console.ReadLine());
                firstSet.Add(input);
            }

            for (int i = 0; i < secondSelection; i++)
            {
                int input = int.Parse(Console.ReadLine());

                finalSet.Add(input);
            }

            foreach (var itemFirstSet in firstSet)
            {
                foreach (var itemFinalSet in finalSet)
                {
                    if (itemFirstSet == itemFinalSet)
                    {
                        Console.Write(itemFirstSet + " ");
                    }
                }
            }
        }
    }
}
