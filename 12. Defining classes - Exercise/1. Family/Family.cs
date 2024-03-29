﻿using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public List<Person> GetTheOldestMember(Person person)
        {
            var oldestPerson = people.Where(x => x.Age >= 30).ToList();
            return oldestPerson;
        }
    }
}
