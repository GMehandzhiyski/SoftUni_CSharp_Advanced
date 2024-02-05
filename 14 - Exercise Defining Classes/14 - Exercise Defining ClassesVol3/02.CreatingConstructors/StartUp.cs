using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {   List<Person> persons = new List<Person>();
            Person person = new Person();
            person.Name = "Peter";
            person.Age = 20;
            persons.Add(person);
            person.Name = "Geroge";
            person.Age = 18;
            Console.WriteLine($"{person.Name} {person.Age}");
            persons.Add(person);
            person.Name = "Jose";
            person.Age = 43;
            Console.WriteLine($"{person.Name} {person.Age}");
            persons.Add(person);
           
        }
    }
}

