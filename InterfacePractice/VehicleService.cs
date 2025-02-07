using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class VehicleService
    {
        public void ServiceVehicle(IVehicle vehicle)
        {
            Console.WriteLine($"Servicing {vehicle.Brand}");
            vehicle.Stop();
            // 服务操作
            vehicle.Start();
        }
    }
}
