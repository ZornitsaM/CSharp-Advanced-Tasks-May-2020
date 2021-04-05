using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_and_dictionaries_advanced_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var filteredNumbers = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!filteredNumbers.ContainsKey(numbers[i]))
                {
                    filteredNumbers[numbers[i]] = 1;
                }

                else
                {
                    filteredNumbers[numbers[i]]++;
                }
            }

            foreach (var (key, value) in filteredNumbers)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
