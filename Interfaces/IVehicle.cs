using System;

namespace Interfaces
{
	public interface IVehicle
	{
		string Brand { get; set; }
		string Model { get; set; }
		int Year { get; set; }
		double Mileage { get; set; }

		bool IsEngineOn();
		void StartEngine();
		void StopEngine();
	}
}