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
        {   //List<Person> persons = new List<Person>();
            //Person person = new Person();
            //person.Name = "Peter";
            //person.Age = 20;
            //persons.Add(person);
            //person.Name = "Geroge";
            //person.Age = 18;
            //Console.WriteLine($"{person.Name} {person.Age}");
            //persons.Add(person);
            //person.Name = "Jose";
            //person.Age = 43;
            //Console.WriteLine($"{person.Name} {person.Age}");
            //persons.Add(person);
            //Person person = new Person("Invan", 20);

            //Family family = new();
            //family.AddMember(person);

            int numberPeople = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < numberPeople; i++)
            {
                string[] nameAndAge = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]); 

                Person  person = new Person(name,age);
              
                family.AddMember(person);
              
            }
            
            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{ oldestMember.Name} {oldestMember.Age}");

        }
    }
}

