using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
	public class CarLot
	{
		public CarLot ()
		{

		}

		public static int numberOfCars = 1;
		//^^^^^^^this is an addition made in STATIC module to make a STATIC method
		//inside a class that is not static making call method different 
		public List<Car> listOfCars { get; set; } = new List<Car>();

	}
}

