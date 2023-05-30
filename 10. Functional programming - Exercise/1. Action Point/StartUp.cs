using System;
using System.Linq;
using System.Collections.Generic;

namespace Functional_Programming_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();

            Action<string[]> print = name=>Console.WriteLine(string.Join("\n", name));
            print(names);
        }
    }
}
