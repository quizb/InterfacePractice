using System;
using System.Collections.Generic;
using InterfacePractice;

class Program
{
    static void Main(string[] args)
    {

        #region 使用接口
        IVehicle vehicle1 = new Car { Brand = "Toyota" };
        IVehicle vehicle2 = new Bike { Brand = "Giant" };

        vehicle1.Start();  // 输出: Engine started
        vehicle2.Stop();   // 输出: Brakes applied

        // 多态集合
        List<IVehicle> garage = new List<IVehicle> { vehicle1, vehicle2 };
        foreach (var v in garage)
        {
            Console.WriteLine(v.Brand);
            v.DisplayType();
        }
        #endregion

        #region 显式接口实现（解决命名冲突）
        var Operator = new HybridOperator();

        // 通过 IDriver 接口调用 Operate 方法
        ((IDriver)Operator).Operate();  // 输出: Driving car

        // 通过 IPilot 接口调用 Operate 方法
        ((IPilot)Operator).Operate();   // 输出: Flying plane
        #endregion

        #region 接口继承(允许一个接口继承自另一个接口)
        IAdvancedVehicle sportsCar = new SportsCar { Brand = "Ferrari" };

        sportsCar.Start();       // 输出: Turbo engine started
        sportsCar.Accelerate(200); // 输出: Accelerating to 200 km/h
        sportsCar.Stop();        // 输出: ABS braking
        #endregion
        #region 接口作为参数

        var service = new VehicleService();
            service.ServiceVehicle(new Car { Brand = "Honda" });
            #endregion
        }
}