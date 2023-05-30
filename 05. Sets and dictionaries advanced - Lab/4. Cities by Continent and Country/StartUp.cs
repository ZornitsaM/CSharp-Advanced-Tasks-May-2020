using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine().Split();
                string land = input[0];
                string country = input[1];
                string town = input[2];

                if (!dictionary.ContainsKey(land))
                {
                    dictionary[land] = new Dictionary<string, List<string>>();
                }
                if (!dictionary[land].ContainsKey(country))
                {
                    dictionary[land][country] = new List<string>();
                }
                dictionary[land][country].Add(town);
            }

            foreach (var current in dictionary)
            {
                Console.WriteLine($"{current.Key}:");
                Console.Write("  ");

                foreach (var item in current.Value)
                {
                    Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
