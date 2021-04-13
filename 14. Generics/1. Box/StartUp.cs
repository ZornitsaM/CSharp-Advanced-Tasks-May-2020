using System;
using System.Linq;
using System.Collections.Generic;

namespace Generics
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < counter; i++)
            {
               double input = double.Parse(Console.ReadLine());

                box.Values.Add(input);
            
            }

            double compareNumber = double.Parse(Console.ReadLine());

            double count = box.GreaterValueThan(compareNumber);

            Console.WriteLine(count);
        } 
    }
}
