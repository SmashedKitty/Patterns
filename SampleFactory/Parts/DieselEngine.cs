using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Parts
{
    public class DieselEngine : Engine
    {
        public DieselEngine()
        {
            Console.WriteLine("Дизельный двигатель");
        }
    }
}
