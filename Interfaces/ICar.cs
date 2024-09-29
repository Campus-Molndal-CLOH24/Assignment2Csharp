using System;

namespace Interfaces
{
	public interface ICar : IVehicle, IDriveable
	{
		int Doors { get; set; }
	}
}