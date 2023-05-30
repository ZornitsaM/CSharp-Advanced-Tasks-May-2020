using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Find_Even___Second_Variant
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            var newNumbers = new List<int>();

            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if (command == "even" && i % 2 == 0)
                {
                    newNumbers.Add(i);
                }
                else if (command == "odd" && i%2 != 0)
                {
                    newNumbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", newNumbers));
        }  
    }
}
