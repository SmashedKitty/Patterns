using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Car
{
    public interface ICar
    {
        string getName();
        string getBody();
        void assembleBody();
        void assembleEngine();
        void assembleWheels();
    }
}
