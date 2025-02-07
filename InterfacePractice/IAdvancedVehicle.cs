using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public interface IAdvancedVehicle : IVehicle
    {
        //定义了一个加速的方法，接受一个速度参数。
        void Accelerate(int speed);
    }
}
