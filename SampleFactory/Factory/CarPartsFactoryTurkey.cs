using SampleFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Factory
{
    public class CarPartsFactoryTurkey : CarPartsFactory
    {
        public Engine CreateEngine()
        {
            return new DieselEngine();
        }

        public Wheels CreateWheels()
        {
            return new HighwayRoadWheels();
        }
    }
}
