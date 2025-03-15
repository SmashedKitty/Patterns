using FactorySample15._03.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctorySample15._03.Car
{
    public class Moskvich : ICar
    {
        private string _name;
        private string _body;
        private string _engine = "Gasoline";
        private string _wheels = "\"14";

        public Moskvich()
        {
            _name = "YuiNiaMi";
            _body = "tin";
        }
        public void AssemblyBody()
        {
            Console.WriteLine("Installing machine body {0} ", _body);
        }

        public void AssemblyEngine()
        {
            Console.WriteLine("Installing machine engine {0} ", _engine);
        }

        public void AssemblyWheel()
        {
            Console.WriteLine("Installing machine wheels {0} ", _wheels);
        }

        public string GetName()
        {
            return _name;
        }
    }

}

