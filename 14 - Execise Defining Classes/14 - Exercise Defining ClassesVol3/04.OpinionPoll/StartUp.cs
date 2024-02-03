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
        {   

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

            Person[] memberOver30 = family.GetMember();
       
            foreach (var member in memberOver30.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }

        }
    }
}

