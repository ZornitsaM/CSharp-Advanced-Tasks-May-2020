using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
       static void Main(string[] args)
        {
            //Family family = new Family();
            List<Person> persons = new List<Person>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                persons.Add(person);
                

            }

            var oldestMembers = persons.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();


            foreach (var item in oldestMembers)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }


    }

}


