using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();
            var sortedDictionary = new Dictionary<string, int>();
            int count = int.Parse(Console.ReadLine());

            PopulateMatrix(dictionary, count);

            string filterAge = Console.ReadLine();
            int filterNumberAge = int.Parse(Console.ReadLine());
            var commandToPrint = Console.ReadLine().Split();

            if (filterAge == "older")
            {
                sortedDictionary = dictionary.Where(x => x.Value >= filterNumberAge).ToDictionary(x => x.Key, x => x.Value);

                if (commandToPrint.Length == 2)
                {
                    PrintNameAndAge(sortedDictionary);
                }
                else if (commandToPrint[0] == "age")
                {
                    PrintAge(sortedDictionary);
                }
                else if (commandToPrint[0] == "name")
                {
                    PrintName(sortedDictionary);
                }
            }
            else if (filterAge == "younger")
            {
                sortedDictionary = dictionary.Where(x => x.Value < filterNumberAge).ToDictionary(x => x.Key, x => x.Value);

                if (commandToPrint.Length == 2)
                {
                    PrintNameAndAge(sortedDictionary);
                }
                else if (commandToPrint[0] == "age")
                {
                    PrintAge(sortedDictionary);
                }
                else if (commandToPrint[0] == "name")
                {
                    PrintName(sortedDictionary);
                }
            }
        }

        private static void PopulateMatrix(Dictionary<string, int> dic, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);

                if (!dic.ContainsKey(name))
                {
                    dic.Add(name, age);
                }
            }
        }

        static void PrintNameAndAge(Dictionary<string, int> name)
        {
            foreach (var item in name)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        static void PrintAge(Dictionary<string, int> name)
        {
            foreach (var item in name)
            {
                Console.WriteLine(item.Value);
            }
        }

        static void PrintName(Dictionary<string, int> name)
        {
            foreach (var item in name)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
