using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Parts
{
    public class CityRoadWheels : Wheels
    {
        public CityRoadWheels()
        {
            Console.WriteLine("Колеса \"15 радиуса");
        }
    }
}
