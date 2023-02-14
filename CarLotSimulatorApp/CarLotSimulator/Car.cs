using System;
namespace CarLotSimulator
{
	public class Car
	{ 
	//default constructor
		public Car()
		{
		}
		//custom constructor
		public Car(int year, string make, string model, string engineNoise, string honkNoise, string isDriveable)
		{
			Year = year;
			Make = make;
			Model = model;
			EngineNoise = engineNoise;
			HonkNoise = honkNoise;
			IsDriveable = isDriveable; 
		}

		//properties
			public int Year { get; set; }
			public string Make { get; set;}
			public string Model { get; set;}
			public string EngineNoise { get; set;}
			public string HonkNoise { get; set; }
			public string IsDriveable { get; set; }

		//methods
		public void MakeEngineNoise(string noise)
		{
			Console.WriteLine($"This car's engine sounds like this: {noise}");
		}

		public void MakeHonkNoise(string horn)
		{
			Console.WriteLine($"The Horn in this car sounds like this: {horn}");
				
		}
	}
}

