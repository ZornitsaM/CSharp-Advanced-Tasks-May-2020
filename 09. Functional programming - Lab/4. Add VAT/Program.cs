using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                var current = VATNumber(numbers[i]);
                Console.WriteLine($"{current:f2}");
            }
        }

        static double VATNumber(double x)
        {
            return x * 1.2;
        }
    }
}
