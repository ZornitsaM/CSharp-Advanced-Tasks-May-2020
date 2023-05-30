using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var hash = new HashSet<string>();

            while (command != "END")
            {
                var currentCommand = command.Split(", ");
                if (currentCommand[0] == "IN")
                {
                    hash.Add(currentCommand[1]);
                }
                else if (currentCommand[0] == "OUT")
                {
                    hash.Remove(currentCommand[1]);
                }
                command = Console.ReadLine();
            }

            if (hash.Count > 0)
            {
                foreach (var item in hash)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
