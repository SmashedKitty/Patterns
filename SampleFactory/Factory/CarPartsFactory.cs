using SampleFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Factory
{
    public interface CarPartsFactory
    {
        Engine CreateEngine();
        Wheels CreateWheels();
    }
}
