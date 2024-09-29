using System;

namespace Interfaces
{
	public interface IVehicleFactory
	{
		IVehicle CreateVehicle(string model, int year, double mileage);
	}
}