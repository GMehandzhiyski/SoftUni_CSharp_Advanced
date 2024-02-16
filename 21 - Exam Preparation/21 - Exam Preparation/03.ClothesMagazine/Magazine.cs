namespace ClothesMagazine
{
    public class Magazine
    {
		private string type;
		private int capacity;
		private List<Cloth> clothes;

        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type
		{
			get { return type; }
			set { type = value; }
		}
		public int Capacity
        {
			get { return capacity; }
			set { capacity = value; }
		}
		public List<Cloth> Clothes
        {
			get { return clothes; }
			set { clothes = value; }
		}

		public void AddCloth(Cloth newCloth)
		{
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(newCloth);
            }
        }

        public bool RemoveCloth(string newColor)
        {
            return Clothes.Remove(Clothes.FirstOrDefault( c => c.Color == newColor));
        }



    }
}
