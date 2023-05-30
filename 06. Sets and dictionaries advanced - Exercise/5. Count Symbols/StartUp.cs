using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary[input[i]] = 1;
                }
                else
                {
                    dictionary[input[i]] += 1;
                }
            }

            var sortedDic = dictionary.OrderBy(x => x.Key).ToArray();

            foreach (var item in sortedDic)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
