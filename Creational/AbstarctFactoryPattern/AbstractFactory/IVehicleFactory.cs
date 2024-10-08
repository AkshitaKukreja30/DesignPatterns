﻿using DesignPatterns.Creational.AbstarctFactoryPattern.AbstractProductInterfaces;

namespace DesignPatterns.Creational.AbstarctFactoryPattern.AbstractFactory
{
    public interface IVehicleFactory
    {
        //Abstract Product A
        IBike CreateBike(string vehicleType);
        //Abstract Product B
        ICar CreateCar(string vehicleType);
    }
}
