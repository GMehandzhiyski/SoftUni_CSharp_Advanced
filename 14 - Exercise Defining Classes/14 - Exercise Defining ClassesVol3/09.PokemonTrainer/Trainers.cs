using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainers
    {
		private string name;
		private int bages;
		private List<Pokemon> pokemons = new List<Pokemon>();

        public Trainers()
        {
			pokemons = new List<Pokemon>();
        }

        public Trainers(string name)
        {
            Name = name;
            Bages = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Bages
        {
			get { return bages; }
			set { bages = value; }
		}

		public List<Pokemon> Pokemons
        {
			get { return pokemons; }
			set { pokemons = value; }
		}

	}
}

