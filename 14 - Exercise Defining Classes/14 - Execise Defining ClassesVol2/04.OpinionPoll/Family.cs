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

        public List<Person> People { get; set; }


    }
}