using SampleFactory.Factory;
using SampleFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Car
{
    public class Tiguan : ICar
    {
        private string _name;
        private string _body;

        private Engine _engine;
        private Wheels _wheels;

        private CarPartsFactory _partsFactory;

        public Tiguan(CarPartsFactory partsFactory)
        {
            _name = "Tiguan";
            _body = "Crossover";
            _partsFactory = partsFactory;
        }

        public void assembleBody()
        {
            Console.WriteLine("Установка кузова {0}", _body);
        }

        public void assembleEngine()
        {
            _engine = _partsFactory.CreateEngine();
        }

        public void assembleWheels()
        {
            _wheels = _partsFactory.CreateWheels();   
        }

        public string getBody()
        {
            return _body;
        }

        public string getName()
        {
            return _name;
        }
    }
}
