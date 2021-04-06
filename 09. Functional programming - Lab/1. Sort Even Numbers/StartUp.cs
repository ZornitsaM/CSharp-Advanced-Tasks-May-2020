using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Functional_programming_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            numbers = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            Console.Write(string.Join(", ", numbers));
        }
    }
}
