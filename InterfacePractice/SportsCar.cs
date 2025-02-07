using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class SportsCar : IAdvancedVehicle
    {
        public string Brand { get; set; }

        public void Start() => Console.WriteLine("Turbo engine started");

        public void Stop() => Console.WriteLine("ABS braking");

        public void Accelerate(int speed) => Console.WriteLine($"Accelerating to {speed} km/h");
    }
}
