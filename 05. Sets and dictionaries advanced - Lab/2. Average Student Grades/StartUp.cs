using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                decimal note = decimal.Parse(input[1]);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary[name] = new List<decimal>();
                    dictionary[name].Add(note);
                }
                else
                {
                    dictionary[name].Add(note);
                }
            }

            foreach (var (key, value) in dictionary)
            {
                Console.WriteLine($"{key} -> {string.Join(" ", value.Select(x => x.ToString("F2")))} (avg: {value.Average():F2})");
            }
        }
    }
}
