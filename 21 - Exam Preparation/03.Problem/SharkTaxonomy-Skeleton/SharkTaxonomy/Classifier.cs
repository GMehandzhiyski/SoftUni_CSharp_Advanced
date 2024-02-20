using System.ComponentModel.Design;
using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
		private int capacity;
		private List<Shark> species;

        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}
		public List<Shark> Species
        {
			get { return species; }
			set { species = value; }
		}

        public int GetCount => Species.Count;

        public void AddShark(Shark shark)
        {

            if (GetCount < Capacity)
            {
                if (species.FirstOrDefault(s => s.Kind == shark.Kind) == null)
                {
                    Species.Add(shark);
                }
                
            }
        }

        public bool RemoveShark(string kind)
        {
            return Species.Remove(Species.FirstOrDefault(c => c.Kind == kind));
        }


        public string GetLargestShark()
        { 
            Shark currShark = Species.OrderByDescending(s => s.Length).FirstOrDefault();
            return currShark.ToString().TrimEnd();
        }

        public double GetAverageLength()
        { 
            return Species.Average(s => s.Length);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetCount} sharks classified:");
            foreach (var shark in Species)
            {
                sb.AppendLine(shark.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }

}
