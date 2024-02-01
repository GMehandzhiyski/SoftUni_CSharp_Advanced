using _03.OldestFamilyMember;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        { 
            int number = int.Parse(Console.ReadLine());

            Family family = new();   

            for (int i = 0; i < number; i++) 
            {
                string[] people = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = people[0];
                int age = int.Parse(people[1]); 

               Person person = new Person(name, age);

                family.AddMember(person);
            }

            Person oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");


           // List<Person> list = new List<Person>(); 
           // //Person people = new ();

           // //people.Name = "gosho";
           //// people.Age = 1;

           // Person people = new Person("ivam", 1);
           // list.Add(people);  
           

           // Console.WriteLine($"{people.Name} {people.Age}");
           // people.Name = "Ivam";
           // people.Age = 2;

           // Console.WriteLine($"{people.Name} {people.Age}");

            
        }

    }
}
