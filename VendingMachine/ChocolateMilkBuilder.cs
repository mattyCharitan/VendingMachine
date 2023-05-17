using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ChocolateMilkBuilder : HotDrinkBuilder
    {
        public ChocolateMilkBuilder(int numOfSugarTeaspoon, int numOfCocoaTeaspoon)
        {
            this.numOfSugarTeaspoon = numOfSugarTeaspoon;
            this.numOfCocoaTeaspoon = numOfCocoaTeaspoon;
        }
        public override string AddSugar(int numOfSugarTeaspoon)
        {
            return base.AddSugar(numOfSugarTeaspoon);
        }
        public override string AddCocoa(int numOfCocoaTeaspoon)
        {
            return base.AddCocoa(numOfCocoaTeaspoon);
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
