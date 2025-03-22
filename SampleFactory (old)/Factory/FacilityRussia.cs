using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFactory.Car;

namespace SampleFactory.Factory
{
    public class FacilityRussia : Facility
    {
        public override ICar GetCar()
        {
            return new Tiguan();
        }
    }
}
