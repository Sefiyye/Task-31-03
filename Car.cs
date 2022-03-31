using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
    internal class Car:Vehicle
    {
        public int FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;


        public Car(int fuelCapacity, double currentFuel, double fuelFor1km, string color, string brand, int millage):base(color, brand, millage)

        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
            FuelFor1km = fuelFor1km;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Car brand: {Brand}, Car Color: {Color}, Car Millage: {Millage}");
        }
        public void Drive()
        {
            bool Search = false;
            Console.WriteLine("Zehmet olmasa gedilecek yolun km-ni qeyd edin");
        }
    }
}
