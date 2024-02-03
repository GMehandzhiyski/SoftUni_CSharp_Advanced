using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
		private string model;
		private Engine engine;
		private Cargo cargo;
		private Tire[] tires;

        public Car()
        {
			
        }
        public Car(string model,
                int speed,
                int power,
                int weight,
                string type,
                double tire1pressure,
                int tire1age,
                double tire2pressure,
                int tire2age,
                double tire3pressure,
                int tire3age,
                double tire4pressure,
                int tire4age)
        {
            Model = model;
            Engine = new(speed, power);
            Cargo = new(weight, type);

            Tires = new Tire[4];
            Tires[0] = new(tire1pressure, tire1age);
            Tires[1] = new(tire2pressure, tire2age);
            Tires[2] = new(tire3pressure, tire3age);
            Tires[3] = new(tire4pressure, tire4age);
        }

        public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public Engine Engine
        {
			get { return engine; }
			set { engine = value; }
		}

		public Cargo Cargo
        {
			get { return cargo; }
			set { cargo = value; }
		}

		public Tire[] Tires
        {
			get { return tires; }
			set { tires = value; }
		}

	}
}

