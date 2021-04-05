using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var hash = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                hash.Add(input);
            }

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
