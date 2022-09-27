using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        
        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDriveable { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        //Example of call method for #1.
        /* public Car(int year, string make, string model, bool isDriveable, string engineNoise, string honkNoise)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = isDriveable;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        } */

        public void MakeEngineNoise (string engineNoise) 
        { 
            Console.WriteLine (engineNoise);
        }
        
        public void MakeHonkNoise (string honkNoise) 
        { 
            Console.WriteLine(honkNoise);
        }

    } 
}
