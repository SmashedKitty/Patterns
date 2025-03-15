using FactorySample15._03;
using FactorySample15._03.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FctorySample15._03.Factory
{
    public class FacilityRu : Facility
    {
        protected override ICar GetCar()
        {
            return new Golf();
        }
    }
}
