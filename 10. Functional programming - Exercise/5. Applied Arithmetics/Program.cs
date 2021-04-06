using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int> addFunc = number => number += 1;
            Func<int, int> multiplyFunc = number => number *= 2;
            Func<int, int> subtractFunc = number => number -= 1;

            Action<int[]> printNumbers = number=>Console.WriteLine(string.Join(" ", number));

            string command = Console.ReadLine();

            while (command!="end")
            {
                if (command=="add")
                {
                    inputNumbers = inputNumbers.Select(addFunc).ToArray();
                }

                else if (command== "multiply")
                {
                    inputNumbers = inputNumbers.Select(multiplyFunc).ToArray();
                }

                else if (command == "subtract")
                {
                    inputNumbers = inputNumbers.Select(subtractFunc).ToArray();
                }

                else if (command == "print")
                {
                    printNumbers(inputNumbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
