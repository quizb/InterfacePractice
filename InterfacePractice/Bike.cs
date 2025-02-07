using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class Bike : IVehicle
    {
        public string Brand { get; set; }

        public void Start() => Console.WriteLine("Pedaling started");

        public void Stop() => Console.WriteLine("Brakes applied");
    }
}
