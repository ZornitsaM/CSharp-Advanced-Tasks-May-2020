using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNumber = int.Parse(Console.ReadLine());
            var divideNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sortedList = new List<int>();

            for (int i = 1; i <= inputNumber; i++)
            {
                sortedList.Add(i);
            }

            Func<int, bool> filter = number =>
             {
                 int count = 0;

                 for (int i = 0; i < divideNumbers.Length; i++)
                 {
                     if (number % divideNumbers[i] == 0)
                     {
                         count++;
                     }
                 }

                 if (count == divideNumbers.Length)
                 {
                     return true;
                 }
                 return false;
             };

            Action<List<int>> print = num => Console.WriteLine(string.Join(" ", num));
            sortedList = sortedList.Where(filter).ToList();
            print(sortedList);
        }
    }
}
