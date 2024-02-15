namespace AutomotiveRepairShop
{
    public class Vehicle
    {
		private string vIN;
		private int mileage;
		private string damage;

        public Vehicle(string vIN, int mileage, string damage)
        {
            VIN = vIN;
            Mileage = mileage;
            Damage = damage;
        }

        public string VIN
		{
			get { return vIN; }
			set { vIN = value; }
		}
		public int Mileage
		{
			get { return mileage; }
			set { mileage = value; }
		}
		public string Damage
		{
			get { return  damage; }
			set {  damage = value; }
		}

        public override string ToString()
        {
            return $"Damage: {damage}, Vehicle: {vIN} ({mileage} km)";
        }

	

    }
}
