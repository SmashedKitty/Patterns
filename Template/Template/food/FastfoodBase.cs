using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.food
{
    public abstract class FastfoodBase
    {
        public void PrepareFood()
        {
            Console.WriteLine("making produkt");
            AddBread();
            AddSalat();
            AddMeat();
            if(isWantToppping())
            {
                AddToping();
            }
        }

        public virtual bool isWantToppping()
        {
            return true;
        }

        protected abstract void AddToping();
        protected abstract void AddMeat();
        protected abstract void AddSalat();

        private void AddBread()
        {
            Console.WriteLine("Adding Bread");
        }
    }
}
