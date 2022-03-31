using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
    internal class Vehicle
    {
        public string Color;
        public string Brand;
        public int Millage;


        public Vehicle(string color, string brand, int millage)
        {
            Color = color;
            Brand = brand;
            Millage = millage;

        }
        public virtual void ShowInfo()
        {

        }
    }
}
