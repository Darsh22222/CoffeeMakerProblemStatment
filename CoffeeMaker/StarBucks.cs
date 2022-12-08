using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class Starbucks : IMakeACoffee
    {
        public bool CheckIngridentAvailablity()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            throw new NotImplementedException();
        }
    }
    public class StubStarbucks : IMakeACoffee
    {
        public bool CheckIngridentAvailablity()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            return "Your Order is recieved";
        }
    }
    public class FakeStarbucks : IMakeACoffee
    {
        public bool CheckIngridentAvailablity()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            return "Your Order is recieved";
        }
    }
}

