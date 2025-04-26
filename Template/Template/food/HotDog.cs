using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.food
{
    public class HotDog : FastfoodBase
    {
        protected override void AddMeat()
        {
            Console.WriteLine("+ soasage");
        }

        protected override void AddSalat()
        {
            Console.WriteLine("+ onion");
        }

        protected override void AddToping()
        {
            Console.WriteLine("+ ketchup");
        }

        public override bool isWantToppping()
        {
            Console.WriteLine("ADD ketchup?");
            var readline = Console.ReadLine();
            if (readline != null && readline.ToLower().Equals("да"))
            {
                return true;
            }
            return false;
        }
    }
}
