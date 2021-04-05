using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var dictionary = new Dictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                var currentCommand = command.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string mag = currentCommand[0];
                string product = currentCommand[1];
                double price = double.Parse(currentCommand[2]);

                if (!dictionary.ContainsKey(mag))
                {
                    dictionary[mag] = new Dictionary<string, double>();
                }

                dictionary[mag].Add(product, price);
                command = Console.ReadLine();
            }

            var finalDic = dictionary.OrderBy(x => x.Key).ToArray();
            foreach (var (key, value) in finalDic)
            {
                Console.WriteLine($"{key}-> ");

                foreach (var currentProduct in value)
                {
                    Console.WriteLine($"Product: {currentProduct.Key}, Price: {currentProduct.Value}");
                }
            }
        }
    }
}
