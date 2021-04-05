using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_and_Dictionaries_Advanced_EX
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            var hash = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string currentName = Console.ReadLine();

                hash.Add(currentName);
            }

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
