using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public interface IVehicle
    {
        
        string Brand { get; set; }

        void Start();
        void Stop();

        void DisplayType() => Console.WriteLine("Generic Vehicle");
        
    }
}
