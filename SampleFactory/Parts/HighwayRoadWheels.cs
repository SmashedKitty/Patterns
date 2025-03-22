using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Parts
{
    public class HighwayRoadWheels : Wheels
    {
        public HighwayRoadWheels()
        {
            Console.WriteLine("Колеса \"17 радиуса");
        }
    }
}
