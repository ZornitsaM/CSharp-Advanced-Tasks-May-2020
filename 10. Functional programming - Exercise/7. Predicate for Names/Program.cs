using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToArray();
            Func<string, bool> sortedNames = name => name.Length <= lenght;
            Action<string[]> printNames = name => Console.WriteLine(string.Join("\n", name));

            names = names.Where(sortedNames).ToArray();

            printNames(names);
        }
    }
}
