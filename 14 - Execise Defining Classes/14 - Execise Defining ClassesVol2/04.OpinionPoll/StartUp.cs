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
            List<Person> listOfPeople = new ();
            int numberPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberPeople; i++)
            {
                string[] inputPeople = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string nameIn = inputPeople[0];
                int ageIn = int.Parse(inputPeople[1]);

                Person person = new Person(nameIn, ageIn);   
                listOfPeople.Add(person);   

            }

            //Family  family = new Family();

            foreach (var currPerson in listOfPeople.OrderBy(p => p.Name))
            {
                if (currPerson.Age > 30)
                {
                    Console.WriteLine($"{currPerson.Name} - {currPerson.Age}");
                }
            }
        }

    }
}
