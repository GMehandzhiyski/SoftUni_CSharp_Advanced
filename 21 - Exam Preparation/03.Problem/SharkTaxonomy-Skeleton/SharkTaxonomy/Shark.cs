namespace SharkTaxonomy
{
    public class Shark
    {
		private string kind;
		private int length;
		private string food;
		private string habitat;

        public Shark(string kind, int length, string food, string habitat)
        {
            Kind = kind;
            Length = length;
            Food = food;
            Habitat = habitat;
        }

        public string Kind
		{
			get { return kind; }
			set { kind = value; }
		}
		public int Length
        {
			get { return length; }
			set { length = value; }
		}
		public string Food
		{
			get { return food; }
			set { food = value; }
		}

		public string Habitat
        {
			get { return habitat; }
			set { habitat = value; }
		}


		public override string ToString()
		{

			return $"{Kind} shark: {Length}m long.\nCould be spotted in the {Habitat}, typical menu: {Food}";


        }

    }
}
