using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ABF
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;

        public Client (AbstractFactory factory)
        { 
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
        }

        public void Run()
        {
            bottle.Interact(water);
        }

    }
}
