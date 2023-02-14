using System;
using System.Reflection;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate car lot with a new car
            CarLot davesCarLot = new CarLot();
            

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            //DOT. NOTATION
            Car futureCar = new Car();
            futureCar.Year = 2020;
            
            futureCar.Make = "Dodge";
            futureCar.Model = "Challenger";
            futureCar.EngineNoise = "Vroom";
            futureCar.HonkNoise = "Beep";
            futureCar.IsDriveable = "Yes";
            davesCarLot.listOfCars.Add(futureCar);
            //OBJECT INITIALIZER SYNTAX
            var dailyDriver = new Car()
            {
                Year = 2022,
                Make = "Tesla",
                Model = "Model X",
                EngineNoise = "eeeee",
                HonkNoise = "meep",
                IsDriveable = "yes",
            };
            davesCarLot.listOfCars.Add(dailyDriver);
            //CUSTOM CONSTRUCTOR
            var kidMobile = new Car(2022, "BMW", "X6", "vrvrvr", "honk", "yes");
            davesCarLot.listOfCars.Add(kidMobile);
            //Call each of the methods for each car
            //CAR 1
            futureCar.MakeEngineNoise(futureCar.EngineNoise);
            futureCar.MakeHonkNoise(futureCar.HonkNoise);
            //CAR 2
            dailyDriver.MakeEngineNoise(dailyDriver.EngineNoise);
            dailyDriver.MakeHonkNoise(dailyDriver.HonkNoise);
            //CAR 3
            kidMobile.MakeEngineNoise(kidMobile.EngineNoise);
            kidMobile.MakeHonkNoise(kidMobile.HonkNoise);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in davesCarLot.listOfCars)
            {
                Console.WriteLine();
                Console.WriteLine(car.Year);
                Console.WriteLine();
                Console.WriteLine(car.Make);
                Console.WriteLine();
                Console.WriteLine(car.Model);
                Console.WriteLine();
                Console.WriteLine(car.EngineNoise);
                Console.WriteLine();
                Console.WriteLine(car.HonkNoise);
                Console.WriteLine();
                Console.WriteLine(car.IsDriveable);

            }
        }
    }
}
