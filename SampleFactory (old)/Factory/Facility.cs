using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFactory.Car;

namespace SampleFactory.Factory
{
    public abstract class Facility
    {
        public abstract ICar GetCar();

        public void BuildCar()
        {
            var car = GetCar();
            Console.WriteLine("Создание машины {0}", car.getName());
            car.assembleBody();
            car.assembleEngine();
            car.assembleWheels();
        }
    }
}
