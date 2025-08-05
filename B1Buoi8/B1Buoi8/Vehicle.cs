using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1Buoi8
{
    internal abstract class Vehicle
    {
        public string Model { get; set; }
        public double Speed { get; set; }

        public Vehicle(string model, double speed)
        {
            Model = model;
            Speed = speed;
        }

        public abstract void DisplayInfo();
    }

    
}
