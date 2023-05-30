using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).FirstOrDefault();

            Console.WriteLine(inputNumbers);
        }
    }
}
