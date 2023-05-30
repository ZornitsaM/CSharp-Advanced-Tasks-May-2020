using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var guest = new HashSet<string>();

            while (command != "PARTY")
            {
                if (command.Length == 8)
                {
                    guest.Add(command);
                }
                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();

            while (secondCommand != "END")
            {
                if (guest.Contains(secondCommand))
                {
                    guest.Remove(secondCommand);
                }
                secondCommand = Console.ReadLine();
            }
            
            Console.WriteLine(guest.Count);

            foreach (var item in guest)
            {
                string current = item;

                if (current[0] >= 47 && current[0] <= 57)
                {
                    Console.WriteLine(item);
                }
            }

            foreach (var item in guest)
            {
                if (item[0] < 47 || item[0] > 57)
                {
                    Console.WriteLine(item);

                }
            }
        }
    }
}
