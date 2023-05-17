using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class TeaBuilder:HotDrinkBuilder
    {
        public TeaBuilder(int numOfSugarTeaspoon)
        {
            this.numOfSugarTeaspoon = numOfSugarTeaspoon;
        }
        public override string AddSugar(int numOfSugarTeaspoon)
        {
            return base.AddSugar(numOfSugarTeaspoon);
        }
        public override string PourHotWater()
        {
            return base.PourHotWater();
        }
        public override string AddTeaExtract()
        {
            return base.AddTeaExtract();
        }
    }
}
