using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class CoffeeBuilder:HotDrinkBuilder
    {
        public CoffeeBuilder(int numOfSugarTeaspoon, int numOfCoffeeTeaspoon)
        {
            this.numOfSugarTeaspoon = numOfSugarTeaspoon;
            this.numOfCoffeeTeaspoon = numOfCoffeeTeaspoon;
        }
        public override string AddSugar(int numOfSugarTeaspoon)
        {
            return base.AddSugar(numOfSugarTeaspoon);
        }
        public override string AddCoffee(int numOfCoffeeTeaspoon)
        {
            return base.AddCoffee(numOfCoffeeTeaspoon);
        }
        public override string PourHotWater()
        {
            return base.PourHotWater();
        }
        public override string PourMilk()
        {
            return base.PourMilk();
        }
    }
}
