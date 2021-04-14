
using Comparing_Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5_Comparing_Objects
{
    class Startup
    {
        private static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                var personInfo = command.Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];
                Person person = new Person(name, age, town);
                people.Add(person);

                command = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());
            Person targetPerson = people[n - 1];
            int matches = 1;

            foreach (var item in people)
            {
                if (item.CompareTo(targetPerson) == 0 && !item.Equals(targetPerson))
                {
                    matches++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }

            else
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
        }
    }
}