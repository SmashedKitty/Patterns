using SampleFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Factory
{
    public class CarPartsFactoryGermany
    {
        public IEngine GetEngine()
        {
            return new DiselEngine();
        }

        public IWheels GetWheels()
        {
            return new CityWheels();
        }
    }
}
