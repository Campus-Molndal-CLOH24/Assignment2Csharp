
using Interfaces;
using System;

namespace Factories
{
	public class CarFactory : IVehicleFactory
	{
		public CarImpl CreateCar(string brand, string model, int year, double mileage, int doors)
		{
			return new CarImpl(brand, model, year, mileage, doors);
		}

		public IVehicle CreateVehicle(string brand, string model, int year, double mileage)
		{
			return new CarImpl(brand, model, year, mileage, 4);
		}

		public IVehicle CreateVehicle(string model, int year, double mileage)
		{
			throw new NotImplementedException();
		}
	}
}


