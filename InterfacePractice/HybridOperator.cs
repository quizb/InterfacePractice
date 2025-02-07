using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class HybridOperator : IDriver, IPilot
    {
        // 显式实现接口方法
        void IDriver.Operate() => Console.WriteLine("Driving car");
        void IPilot.Operate() => Console.WriteLine("Flying plane");
    }
}
