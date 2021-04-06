using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Applied_Arithmetics___Second_Variant
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                Func<int, int> resultAdd = number => number += 1;
                Func<int, int> resultSubtract = number => number -= 1;
                Func<int, int> resultMultuply = number => number *= 2;

                Action<List<int>> print = number => Console.WriteLine(string.Join(" ", numbers));

                if (command == "add")
                {
                    numbers = numbers.Select(resultAdd).ToList();
                }

                else if (command == "subtract")
                {
                    numbers = numbers.Select(resultSubtract).ToList();
                }

                else if (command == "multiply")
                {
                    numbers = numbers.Select(resultMultuply).ToList();
                }

                else if (command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
