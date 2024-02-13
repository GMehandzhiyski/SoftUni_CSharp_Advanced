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
			if (!Stall.Contains(product) && Stall.Count > Capacity)
			{ 
			 Stall.Add(product);
			}
        }

		public void RemoveProduct(Product product) 
		{
		
		}

    }
}
