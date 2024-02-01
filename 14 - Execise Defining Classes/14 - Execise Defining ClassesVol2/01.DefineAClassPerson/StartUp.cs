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
            List<Person> list = new List<Person>(); 
            //Person people = new ();

            //people.Name = "gosho";
           // people.Age = 1;

            Person people = new Person("ivan", 1);
            list.Add(people);  
           

            Console.WriteLine($"{people.Name} {people.Age}");
            people.Name = "Ivam";
            people.Age = 2;

            Console.WriteLine($"{people.Name} {people.Age}");

            
        }

    }
}
