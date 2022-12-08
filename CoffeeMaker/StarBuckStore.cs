using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarBuckStore
    {
        private readonly IMakeACoffee service;
        public StarBuckStore(IMakeACoffee service)
        {
            this.service = service;
        }
        public string OrderCoffee(int sugarPerPerson, int coffeeCount)
        {
            if (service.CheckIngridentAvailablity())
            {
                return service.CoffeeMaking(sugarPerPerson, coffeeCount);
            }
            else
            {
                return "Sorry, Your coffee is not available.";
            }
        }
    }
}
