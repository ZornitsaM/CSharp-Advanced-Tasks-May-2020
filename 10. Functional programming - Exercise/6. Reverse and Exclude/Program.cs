using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int divideNumber = int.Parse(Console.ReadLine());

            Predicate<int> filter = num => num % divideNumber == 0;
            Action<List<int>> print = num => Console.WriteLine(string.Join(" ", num));
            inputNumbers = inputNumbers.FindAll(number=>!filter(number)).ToList();
            print(inputNumbers);
        }
    }
}
