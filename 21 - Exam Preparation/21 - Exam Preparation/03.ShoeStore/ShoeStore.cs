using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        private string name;
        private int storageCapacity;
        private List<Shoe> shoes;

        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int StorageCapacity
        {
            get { return storageCapacity; }
            set { storageCapacity = value; }
        }

        public List<Shoe> Shoes
        {
            get { return shoes; }
            set { shoes = value; }
        }

        public int Count => Shoes.Count;

        public string AddShoe(Shoe newShoe)
        {
            if (Count < StorageCapacity)
            {
                Shoes.Add(newShoe);
                Shoe currShoe = Shoes.FirstOrDefault(s => s.Type == newShoe.Type
                                                        && s.Material == newShoe.Material);
                return ($"Successfully added {currShoe.Type} {currShoe.Material} pair of shoes to the store.");
            }
            else
            {
                return ("No more space in the storage room.");
            }
        }

        public int RemoveShoes(string material)
        {
            int removedShoes = 0;

            for (int i = 0; i < shoes.Count; i++)
            {
                if (shoes[i].Material == material.ToLower())
                {
                    shoes.RemoveAt(i--);
                    removedShoes++;
                }
            }

            return removedShoes;
        }
        
        public Shoe GetShoeBySize(double size) => this.shoes.FirstOrDefault(s => s.Size == size);

        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> listToReturn = new List<Shoe>();
            foreach (Shoe shoe in this.shoes)
            {
                if (shoe.Type == type.ToLower())
                {
                    listToReturn.Add(shoe);
                }
            }
            return listToReturn;
        }
        public string StockList(double size, string type)
        {
            List<Shoe> stockList = this.shoes.Where(s => s.Size == size && s.Type == type).ToList();

            StringBuilder sb = new StringBuilder();
            if (stockList.Count == 0)
            {
                sb.AppendLine("No matches found!");
            }
            else
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (Shoe shoe1 in stockList)
                {
                    sb.AppendLine(shoe1.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}