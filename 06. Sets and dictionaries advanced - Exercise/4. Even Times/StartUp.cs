using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(inputNumber))
                {
                    dictionary[inputNumber] = 1;
                }

                else
                {
                    dictionary[inputNumber] += 1;
                }
            }
            foreach (var item in dictionary)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
