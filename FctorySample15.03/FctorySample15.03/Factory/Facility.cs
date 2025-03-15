using FactorySample15._03.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctorySample15._03.Factory
{
    public abstract class Facility
    {
        protected abstract ICar GetCar();
        public ICar BuildCar()
        {
            var car = GetCar();
            Console.WriteLine("Creating machine pi-pu-pi... {0}", car.GetName());
            car.AssemblyWheel();
            car.AssemblyEngine();
            car.AssemblyBody();

            return car;
        }

    }
}
