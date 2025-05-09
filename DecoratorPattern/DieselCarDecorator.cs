﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //The following Concrete Decorator class will add Diesel Engine to the Existing Car
    class DieselCarDecorator : CarDecorator
    {

        //Pass the existing car object while creating the Instance of PetrolCarDecorator class
        //Also pass the same existing pizza object to the base class constructor 
        //i.e. CarDecorator abstract class constructor
        public DieselCarDecorator(ICar car) : base(car)
        {
        }
        //Overriding the ManufactureCar method to add Petrol Engine
        public override ICar ManufactureCar()
        {
            //First Call the Concrete Components ManufactureCar Method 
            car.ManufactureCar();
            //Then Add a Petrol Engine by calling the AddEngine Method
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMWCar)
            {
                BMWCar.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
            }
        }
    }
}
