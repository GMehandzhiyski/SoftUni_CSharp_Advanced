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
		private string engine;
		private string weight;
		private string color;

        public Car()
        {
			
        }
        public Car(string model, string engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight  = weight;
			Color = color;

            
        }

        public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public string Engine
        {
			get { return engine; }
			set { engine = value; }
		}

		public string Weight
        {
			get { return weight; }
			set { weight = value; }
		}

		public string Color
        {
			get { return color; }
			set { color = value; }
		}

	}
}

