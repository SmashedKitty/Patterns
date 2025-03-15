using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample15._03.Car
{
    public interface ICar
    {
        string GetName();
        void AssemblyWheel();
        void AssemblyBody();
        void AssemblyEngine();
    }
}
