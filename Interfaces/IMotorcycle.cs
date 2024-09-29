using System;

namespace Interfaces
{
	public interface IMotorcycle : IVehicle
	{
		string EngineType { get; set; }
	}
}