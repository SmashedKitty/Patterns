using FactorySample15._03.Car;
using FactorySample15._03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FctorySample15._03.Car;

namespace FctorySample15._03.Factory
{
    public class FacilityTr : Facility
    {
        protected override ICar GetCar()
        {
            return new Moskvich();
        }
    }
}
