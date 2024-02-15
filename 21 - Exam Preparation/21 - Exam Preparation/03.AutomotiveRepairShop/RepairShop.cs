//using System.Text;

//namespace AutomotiveRepairShop
//{
//    public class RepairShop
//    {
//        public RepairShop(int capacity)
//        {
//            Capacity = capacity;
//            this.Vehicles = new List<Vehicle>();
//        }

//        public int Capacity { get; set; }

//        public List<Vehicle> Vehicles { get; set; }

//        public void AddVehicle(Vehicle vehicle)
//        {
//            if (this.Vehicles.Count < this.Capacity)
//            {
//                this.Vehicles.Add(vehicle);
//            }
//        }

//        public bool RemoveVehicle(string vin) => this.Vehicles.Remove(this.Vehicles.FirstOrDefault(v => v.VIN == vin));

//        public int GetCount() => this.Vehicles.Count;

//        public Vehicle GetLowestMileage() => this.Vehicles.OrderBy(v => v.Mileage).FirstOrDefault();

//        public string Report()
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.AppendLine("Vehicles in the preparatory:");

//            foreach (Vehicle v in this.Vehicles)
//            {
//                sb.AppendLine(v.ToString());
//            }
//            return sb.ToString().TrimEnd();
//        }
//    }
//}


using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        private int capacity;
        private List<Vehicle> vehicles;

        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public List<Vehicle> Vehicles
        {
            get { return vehicles; }
            set { vehicles = value; }
        }

        public void AddVehicle(Vehicle newVehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(newVehicle);
            }
        }

        public bool RemoveVehicle(string vinNumber)
        {
            return Vehicles.Remove(Vehicles.FirstOrDefault(v => v.VIN == vinNumber));

        }

        public int GetCount()
        {
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            Vehicle mileAge = Vehicles.OrderBy(v => v.Mileage).FirstOrDefault();
            return mileAge;
        }
   
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (Vehicle vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
