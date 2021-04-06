using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _2._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> myFunk = int.Parse;

            var numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(myFunk).ToList();

            var sum = SumAll(numbers);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(sum);
        }

        static int SumAll(List<int> numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }
            return result;
        }
    }
}
