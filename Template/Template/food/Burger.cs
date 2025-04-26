using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.food
{
    public class Burger : FastfoodBase
    {
        protected override void AddMeat()
        {
            Console.WriteLine("+ lamb");
        }

        protected override void AddSalat()
        {
            Console.WriteLine("+ salt");
        }

        protected override void AddToping()
        {
            Console.WriteLine("+ ketchup");
        }
    }
}
