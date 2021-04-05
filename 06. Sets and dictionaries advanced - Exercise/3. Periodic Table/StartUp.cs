using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var hashSet = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();

                for (int j = 0; j < input.Length; j++)
                {
                    hashSet.Add(input[j]);
                }
            }

            var sortedHashSet = hashSet.OrderBy(x => x).ToArray();
            foreach (var item in sortedHashSet)
            {
                Console.Write(item + " ");
            }
        }
    }
}
