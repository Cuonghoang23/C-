using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1Buoi8
{
    internal class Motorbike : Vehicle, IEngine
    {
        public int EngineCapacity { get; set; }

        public Motorbike(string model, double speed, int engineCapacity)
            : base(model, speed)
        {
            EngineCapacity = engineCapacity;
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
            Console.WriteLine($"Xe may: Model = {Model}, Toc do = {Speed} km/h, Dung tích dong cơ = {EngineCapacity}cc");
        }
    }
}
