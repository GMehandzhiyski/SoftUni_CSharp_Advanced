using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Engine
    {
		private string model;
		private int power;
		private string displacement;
		private string efficiency;

        public Engine()
        {
				
        }
        public Engine(string model, int power, string displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model
		{
			get { return model; }
			set { model = value; }
		}
		public int Power
		{
			get { return power; }
			set { power = value; }
		}
		public string Displacement
		{
			get { return displacement; }
			set { displacement = value; }
		}

		public string Efficiency
        {
			get { return efficiency; }
			set { efficiency = value; }
		}






	}
}

