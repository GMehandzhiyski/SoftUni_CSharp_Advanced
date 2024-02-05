using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
		private string model;
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double travelledDistance;

        public Car()
        {
				
        }
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer, double travelledDistance)
			
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
           
        }

        public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public double FuelAmount
        {
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}

		public double FuelConsumptionPerKilometer
        {
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}

		public double TravelledDistance
        {
			get { return travelledDistance; }
			set { travelledDistance = value; }
		}

		public void DriveCar(double amountOfKm)
		{
            double movingRange = amountOfKm * fuelConsumptionPerKilometer;
            if (movingRange <= FuelAmount)
            {
                fuelAmount -= movingRange;
                travelledDistance += amountOfKm;
            }
            else 
			{
                Console.WriteLine("Insufficient fuel for the drive");
            }
		
		}





	}
}

