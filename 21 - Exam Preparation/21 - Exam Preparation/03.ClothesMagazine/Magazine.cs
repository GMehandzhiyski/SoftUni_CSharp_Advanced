
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color)
        {
            return Clothes.Remove(Clothes.FirstOrDefault(c => c.Color == color));
        }

        public Cloth GetSmallestCloth()
        {
            Cloth currCloth = Clothes.OrderBy(c => c.Size).FirstOrDefault();
            return currCloth;
        }


        public Cloth GetCloth(string color)
        {
            Cloth currCloth = Clothes.Where(c => c.Color == color).FirstOrDefault();
            return currCloth;
        }

        public int GetClothCount()
        {
            return Clothes.Count;
        }


        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");
            foreach (var currClothes in Clothes.OrderBy(c => c.Size))
            {
                sb.AppendLine(currClothes.ToString());
            }
            return sb.ToString().TrimEnd();
        }
        //public string Report()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine($"{this.Type} magazine contains:");

        //    foreach (var cloth in this.Clothes.OrderBy(c => c.Size))
        //    {
        //        sb.AppendLine(cloth.ToString());
        //    }

        //    return sb.ToString().TrimEnd();
        //}
    }
}
