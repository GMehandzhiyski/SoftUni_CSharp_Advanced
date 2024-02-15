using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
		private int buttonCapacity;
		private List<Drink> drinks;
		private int getCount;

        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>();
        }

        public int ButtonCapacity
		{
			get { return  buttonCapacity; }
			set {  buttonCapacity = value; }
		}
		public List<Drink> Drinks
		{
			get { return drinks; }
			set { drinks = value; }
		}
		public int GetCount
        {
			get { return Drinks.Count; }
			set { getCount = value; }
		}

		public void AddDrink(Drink drink) 
		{
            if (Drinks.Count < ButtonCapacity)
            {
				Drinks.Add(drink);
            }
        }

		public bool RemoveDrink(string nameProduct)
		{
			return Drinks.Remove(Drinks.FirstOrDefault(d => d.Name == nameProduct));
		}

		public Drink GetLongest()
		{
			Drink volume = Drinks.OrderByDescending(d => d.Volume).FirstOrDefault();
			return volume;
		}
        public Drink GetCheapest()
        {
            Drink price = Drinks.OrderBy(d => d.Price).FirstOrDefault();
            return price;
        }
        public string BuyDrink(string nameProduct)
        {
			Drink product = Drinks.Where(d => d.Name == nameProduct).FirstOrDefault();
            return product.ToString().TrimEnd();
        }

        public string Report()
        {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Drinks available:");
           foreach (var drink in Drinks) 
			{
             //  sb.AppendLine(drink);
            }
			return sb.ToString().TrimEnd();
        }
    }
}
