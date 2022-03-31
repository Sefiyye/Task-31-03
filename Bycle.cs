using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
    internal class Bycle:Vehicle
    {
        public Bycle(string color, string brand, int millage): base(color, brand, millage)
        {
        
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Bycle Color: {Color}, Bycle Brand: {Brand}, Bycle Millage: {Millage}");
        }
        public void Drive()
        {
            Console.WriteLine("Zehmet olmasa gedilecek yolun kim-ni qeyd edin");
        }
    }
}
