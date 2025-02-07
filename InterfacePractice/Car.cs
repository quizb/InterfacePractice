using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class Car : IVehicle
    {
        public string Brand { get; set; }

        public void Start() => Console.WriteLine("Engine started");

        public void Stop() => Console.WriteLine("Engine stopped");

        public void DisplayType() => Console.WriteLine("Car");
    }
}
