using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var result = DateModifier.GetDifferenceInDaysBetweenTwoDates(firstDate, secondDate);
            Console.WriteLine(result);
        }
    }
}
