using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_13.__TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            int sumNumbers = 0;

            for (int i = 0; i < names.Length; i++)
            {
                string currentName = names[i];

                for (int j = 0; j < currentName.Length; j++)
                {
                    int currentCharInNumber = (char)(currentName[j]);
                    sumNumbers += currentCharInNumber;
                }

                if (sumNumbers >= sum)
                {
                    Console.WriteLine(currentName);
                    break;
                }

                else
                {
                    sumNumbers = 0;
                    continue;

                }
            }
        }
    }
}
