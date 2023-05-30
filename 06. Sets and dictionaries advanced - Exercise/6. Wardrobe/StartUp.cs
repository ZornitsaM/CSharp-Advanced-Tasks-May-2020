using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, Dictionary<string, int>>();
            var symbols = new string[] { ",", " -> " };

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];

                if (!dictionary.ContainsKey(color))
                {
                    dictionary[color] = new Dictionary<string, int>();

                    for (int j = 1; j < input.Length; j++)
                    {
                        if (dictionary[color].ContainsKey(input[j]))
                        {
                            dictionary[color][input[j]] += 1;
                        }
                        else
                        {
                            dictionary[color][input[j]] = 1;
                        }
                    }
                }
                else
                {
                    for (int j = 1; j < input.Length; j++)
                    {
                        if (!dictionary[color].ContainsKey(input[j]))
                        {
                            dictionary[color][input[j]] = 1;
                        }
                        else
                        {
                            dictionary[color][input[j]] += 1;
                        }
                    }
                }
            }

            var filter = Console.ReadLine().Split();

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var current in item.Value)
                {
                    if (item.Key == filter[0] && current.Key == filter[1])
                    {
                        Console.WriteLine($"* {current.Key} - {current.Value}(found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {current.Key} - {current.Value}");
                    }
                }
            }
        }
    }
}
