using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
		private string name;
		private int age;

        public Person()
        {
            Name = "No name";
			Age = 1;
        }
        public Person(int age)
			: this()
        {
            Age = age;
        }
        public Person(string name, int age)
            : this(age)
        {
            Name = name;
            Age = age;
        }

        //public Car(string make, string model, int year)
        // : this()
        //{
        //    Make = make;
        //    Model = model;
        //    Year = year;
        //}
        //public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        //    : this(make, model, year)
        //{
        //    FuelQuantity = fuelQuantity;
        //    FuelConsumption = fuelConsumption;
        //}

        //public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine[] engines, Tire[] tires)
        //    : this(make, model, year, fuelQuantity, fuelConsumption)
        //{
        //    Engines = engines;
        //    Tires = tires;
        //}

        public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int Age
		{
			get { return age; }
			set { age = value; }
		}
	}
}
