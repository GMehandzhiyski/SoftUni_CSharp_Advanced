﻿using System.Text;

namespace CarManufacturer
{
	class Car
	{
		private string make;
		private string model;
		private int year;
		private double fuelQuantity;
		private double fuelConsumption;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
			:this()
        {
            Make = make;
			Model = model;	
			Year = year;
        }
		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
			: this(make, model, year)
		{
			FuelQuantity = fuelQuantity;
			FuelConsumption = fuelConsumption;
		}

		public string Make
		{
			get { return make; }
			set { make = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		public double FuelQuantity
		{
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}
		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}

		public void Drive(double distance)
		{
			if ((FuelQuantity - (distance * fuelConsumption)) > 0)
			{
				fuelQuantity -= distance * fuelConsumption;
			}
			else
			{
				Console.WriteLine("Not enough fuel to perform this trip!");
			}

		}

		public string WhoAmI()
		{
			StringBuilder sb = new();
			sb.AppendLine($"Make: {Make}");
			sb.AppendLine($"Model: {Model}");
			sb.AppendLine($"Year: {Year}");
			sb.AppendLine($"Fuel: {FuelQuantity:f2}");

			return sb.ToString();
		}

	}
}
