using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OldestFamilyMember
{
	internal class Family
	{
		private List<Person> people;

		public Family() 
		{
			people = new List<Person>();
		}

		public List<Person> People
        {
			get { return people; }
			set { people = value; }
		}


		public void AddMember(Person member)
		{ 
			people.Add(member);

            //Console.WriteLine(string.Join(" ",people));
        }

		public Person GetOldestMember() 
		{
			return People.MaxBy(p => p.Age);
		}
	}
}
