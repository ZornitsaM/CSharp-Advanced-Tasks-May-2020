using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printNames = name => Console.WriteLine($"Sir {name}");

            Console.ReadLine().Split().ToList().ForEach(printNames);
        }
    }
}
