using System;
using System.Linq;
using System.Collections.Generic;

namespace Tuple
{
    public class StartUp

    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var inputBeers = Console.ReadLine().Split();
            var inputNumbers = Console.ReadLine().Split();

            string fullName = input[0] + " " + input[1];
            string city = input[2];
            string name = inputBeers[0];
            int countBeers = int.Parse(inputBeers[1]);
            int numbersOne = int.Parse(inputNumbers[0]);
            double numbersTwo = double.Parse(inputNumbers[1]);

            var personInfo = new MyTuple<string, string>(fullName, city);
            var personBeers = new MyTuple<string, int>(name, countBeers);
            var numbersInfo = new MyTuple<int, double>(numbersOne, numbersTwo);

            Console.WriteLine(personInfo);
            Console.WriteLine(personBeers);
            Console.WriteLine(numbersInfo);
        }
    }
}
