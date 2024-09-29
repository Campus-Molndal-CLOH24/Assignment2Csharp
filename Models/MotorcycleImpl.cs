using Interfaces;
using System;

public class MotorcycleImpl : IMotorcycle
{
	public string Brand { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }
	public double Mileage { get; set; }
	public string EngineType { get; set; }
	private bool engineOn;

	public MotorcycleImpl(string brand, string model, int year, double mileage, string engineType)
	{
		Brand = brand;
		Model = model;
		Year = year;
		Mileage = mileage;
		EngineType = engineType;
		engineOn = false;
	}

	public bool IsEngineOn() => engineOn;

	public void StartEngine()
	{
		engineOn = true;
	}

	public void StopEngine()
	{
		engineOn = false;
	}

	public override string ToString()
	{
		return $"Motorcycle: {Brand} {Model} ({Year}), Engine: {EngineType}, Mileage: {Mileage:F1}";
	}
}
