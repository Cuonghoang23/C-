using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1Buoi8
{
    internal class Car : Vehicle, IEngine
    {
        string FuelTyle { get; set; }
        public Car(string model, double speed, string fuelType)
        : base(model, speed)
        {
            FuelTyle = fuelType;
        }

        public void StartEngine()
        {
            Console.WriteLine($"Dong co khoi dong.");
        }

        public void StopEngine()
        {
            Console.WriteLine($"Dong co dung lai.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Xe hoi: Model = {Model}, Toc do = {Speed} km/h, Nhien lieu = {FuelTyle}");
        }

    }
}
