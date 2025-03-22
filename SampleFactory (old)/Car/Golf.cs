using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.Car
{
    public class Golf : ICar
    {
        private string _name;
        private string _body;
        private string _engine = "Gasoline";
        private string _wheels = "\"14";

        public Golf()
        {
            _name = "Golf";
            _body = "Hatchback";
        }

        public void assembleBody()
        {
            Console.WriteLine("Установка кузова {0}", _body);
        }

        public void assembleEngine()
        {
            Console.WriteLine("Установка двигателя {0}", _engine);
        }

        public void assembleWheels()
        {
            Console.WriteLine("Установка колёс {0} размера", _wheels);
        }

        public string getBody()
        {
            return _body;
        }

        public string getEngine()
        {
            return _engine;
        }

        public string getName()
        {
            return _name;
        }

        public string getWheels()
        {
            return _wheels;
        }
    }
}
