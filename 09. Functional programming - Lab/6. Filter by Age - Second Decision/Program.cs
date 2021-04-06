using System;
using System.Linq;
using System.Collections.Generic;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalCats = int.Parse(Console.ReadLine());
            var cats = new List<Cat>();

            for (int i = 0; i < totalCats; i++)
            {
                var currentCatData = Console.ReadLine().Split(", ");

                cats.Add(new Cat
                {
                    Name = currentCatData[0],
                    Age = int.Parse(currentCatData[1])
                });

            }
            var filter = Console.ReadLine();
            var ageToFilter = int.Parse(Console.ReadLine());

            Func<Cat, bool> myFilter = cat => true;

            if (filter == "older")
            {
                myFilter = c => c.Age >= ageToFilter;
            }

            else if (filter == "younger")
            {
                myFilter = c => c.Age < ageToFilter;
            }

            var outputCats = cats.Where(myFilter).ToDictionary(x => x.Name, y => y.Age);

            var outputFormat = Console.ReadLine().Split();

            if (outputFormat.Length == 2)
            {
                PrintNameAndAge(outputCats);
            }

            else if (outputFormat[0] == "age")
            {
                PrintAge(outputCats);
            }

            else if (outputFormat[0] == "name")
            {
                PrintName(outputCats);
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
