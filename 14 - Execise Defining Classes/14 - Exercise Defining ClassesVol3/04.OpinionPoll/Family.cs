using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
		private List<Person> persons;

        public Family()
        {
            persons = new List<Person>();
        }

        public List<Person> Persons
		{
			get { return persons; }
			set { persons = value; }
		}

		public void AddMember(Person members)
		{
			persons.Add(members);
		}

		public Person[] GetMember()
		{
			Person[] oldestPerson = persons
                .Where(p => p.Age > 30)
                .OrderByDescending(p => p.Name)
				.Select(p => p)
				.ToArray();
			return oldestPerson;
		}
	}
}
