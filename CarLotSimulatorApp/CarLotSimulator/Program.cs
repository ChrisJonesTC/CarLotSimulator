using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bonus 2- Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();
            
            //
            var myCar = new Car();
            var myVan = new Car();
            var dreamCar = new Car();
            //Static Exercise
            var favCar = new Car();
            Console.WriteLine($"Number of cars in the car lot {CarLot.numberOfCars}");
            var myTruck = new Car();
            Console.WriteLine($"Number of cars in the car lot {CarLot.numberOfCars}");
            var oldCar = new Car();
            Console.WriteLine($"Number of cars in the car lot {CarLot.numberOfCars}");

            myCar.Year = 2016;
            myCar.Make = "Kia";
            myCar.Model = "Optima";
            myCar.IsDriveable = true;
            myCar.EngineNoise = "normal";
            myCar.HonkNoise = "toot";
            
            //Bonus 2 Added myCar to CarLot list
            lot.Cars.Add(myCar);    

            //Examples of syntax
            //1. Uses the contructor to allow parameter values to be placed inside properties
            //var myCar = new Car(2016, "Kia", "Optima", true, "normal", "toot");
            //2. Object Initializer Syntax
            /*var myCar = new Car()
            {
                Year = 2016,
                Make = "Kia",
                Model = "Optima",
                IsDriveable = true,
                EngineNoise = "normal",
                HonkNoise = "toot"
            }; */

            myVan.Year = 2010;
            myVan.Make = "Ford";
            myVan.Model = "Transit";
            myVan.IsDriveable = true;
            myVan.EngineNoise = "clunky";
            myVan.HonkNoise = "beep";

            //Bonus 2- Added myVan to CarLot list
            lot.Cars.Add(myVan);

            //Examples of syntax
            //1. Uses the contructor to allow parameter values to be placed inside properties
            // var myVan = new Car(2010, "Ford", "Transit", true, "clunky", "beep");
            //2. Object Initializer Syntax
            /*var myVan = new Car()
            {
                Year = 2010,
                Make = "Ford",
                Model = "Transit",
                IsDriveable = true,
                EngineNoise = "clunky",
                HonkNoise = "beep"
            };    */

            dreamCar.Year = 2022;
            dreamCar.Make = "Dodge";
            dreamCar.Model = "Hellcat";
            dreamCar.IsDriveable = true;
            dreamCar.EngineNoise = "loud";
            dreamCar.HonkNoise = "custom";

            //Bonus 2- Added dreamCar to CarLot list
            lot.Cars.Add(dreamCar);

            //Examples of syntax
            //1. Uses the contructor to allow parameter values to be placed inside properties
            // var dreamCar = new Car(2022, "Dodge", "Hellcat", true, "loud", "custom");
            //2. Object Initializer Syntax
            /*var dreamCar = new Car()
            {
                Year = 2022,
                Make = "Dodge",
                Model = "Hellcat",
                IsDriveable = true,
                EngineNoise = "loud",
                HonkNoise = "custom"
            };    */

            var carOptions = new List<Car>();
            carOptions.Add(myCar);
            carOptions.Add(myVan);
            carOptions.Add(dreamCar);

            Console.WriteLine("Car Lot Simulator Exercise");
            Console.WriteLine("------------------------------------------------------------------");
            
            //Call Methods
            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);
            
            myVan.MakeEngineNoise(myVan.EngineNoise);
            myVan.MakeHonkNoise(myVan.HonkNoise);
            
            dreamCar.MakeEngineNoise(dreamCar.EngineNoise);
            dreamCar.MakeHonkNoise(dreamCar.HonkNoise); 
           

                Console.WriteLine("Vehicle Specifications");
                Console.WriteLine("----------------------");
            foreach (var Car in carOptions) 
            { 
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"Year: {Car.Year}  make: {Car.Make}  model: {Car.Model}  Is the car driveable: " +
                    $"{Car.IsDriveable}  Sound of engine:  {Car.EngineNoise}  Sound of horn:  {Car.HonkNoise}  ");
            }
            
                Console.WriteLine("------------------------------------------------------------------");


            //Bonus 2- At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var Car in lot.Cars) 
            {
                Console.WriteLine($"Year:  {Car.Year}  Make: {Car.Make}  Model:  {Car.Model}");
            }


            //Done

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
