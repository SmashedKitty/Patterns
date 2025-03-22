using SampleFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Factory
{
    public class CarPartsFactoryRussia : CarPartsFactory
    {
        public Engine CreateEngine()
        {
            return new GasolineEngine();
        }

        public Wheels CreateWheels()
        {
            return new CityRoadWheels();
        }
    }
}
