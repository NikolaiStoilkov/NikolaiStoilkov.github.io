using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Family
    {
        public List<Person> people { get; set; }

        public Family()
        {
            people = new List<Person>();
        }
        public void AddMember(Person member)
        {
            if (!people.Contains(member))
            {
                people.Add(member);
            }
        }

        public Person GetOldestMember()
        {
            int oldestMember = int.MinValue;

            Person person = new Person();
            foreach (var member in people)
            {
                if (member.Age > oldestMember)
                {
                    oldestMember = member.Age;
                    person = member;
                }
            }

            return person;
        }


       
    }
}
