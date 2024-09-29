using Interfaces;
/* using Models; */

namespace Factories
{
	public class MotorcycleFactory : IVehicleFactory
	{
		public IVehicle CreateVehicle(string model, int year, double mileage)
		{
			return new MotorcycleImpl("Harley Davidson", model, year, mileage, "V-Twin");
		}

		public MotorcycleImpl CreateMotorcycle(string brand, string model, int year, double mileage, string engineType)
		{
			return new MotorcycleImpl(brand, model, year, mileage, engineType);
		}
	}
}
