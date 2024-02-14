using System.Text;

namespace GroceriesManagement
{
    public class GroceriesStore
    {
		private int capacity;
		private double turnover;
		private List<Product> stall;

        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new List<Product>();
        }

        public List<Product> Stall
		{
			get { return stall; }
			set { stall = value; }
		}


		public double Turnover
		{
			get { return turnover; }
			set { turnover = value; }
		}


		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}


        public void AddProduct(Product product)
        {
			if (Stall.Contains(product) || Stall.Count >= Capacity)
			{
				return;
			}
            Stall.Add(product);
        }

		public bool  RemoveProduct(string product) 
		{
			 return Stall.Remove(Stall.FirstOrDefault(c => c.Name == product));
		}

		public string SellProduct(string name, double quantity)
		{
			if (!Stall.Any(s => s.Name == name))
			{
                return "Product not found";
            }
	
                Product currProduct = Stall.First(c => c.Name == name);
                Turnover += currProduct.Price * quantity;
                return $"{currProduct.Name} = {(currProduct.Price * quantity):f2}$";    
          
		}

		public  string GetMostExpensive() 
		{
			return stall.OrderByDescending(s => s.Price).FirstOrDefault().ToString();
		}

		public string CashReport()
		{
			return $"Total Turnover: {Turnover:F2}$";

        }

		public string PriceList()
		{
			StringBuilder sb = new StringBuilder();	

            sb.AppendLine("Groceries Price List:");

            foreach (var currStall in stall)
            {
				sb.AppendLine(currStall.ToString());
            }
			
			return sb.ToString().TrimEnd();
        }
    }
}
