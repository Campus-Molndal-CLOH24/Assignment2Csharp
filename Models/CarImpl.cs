using Interfaces;
using System;

public class CarImpl : ICar
{
	public string Brand { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }
	public double Mileage { get; set; }
	public int Doors { get; set; }
	private bool engineOn;

	public CarImpl(string brand, string model, int year, double mileage, int doors)
	{
		Brand = brand;
		Model = model;
		Year = year;
		Mileage = mileage;
		Doors = doors;
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

	public string Drive()
	{
		return "Driving the car";
	}

	public override string ToString()
	{
		return $"Car: {Brand} {Model} ({Year}), Doors: {Doors}, Mileage: {Mileage:F1}";
	}
}
