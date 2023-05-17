using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class HotDrinkBuilder
    {
        protected int numOfSugarTeaspoon;
        protected int numOfCoffeeTeaspoon;
        protected int numOfCocoaTeaspoon;
        public virtual string AddSugar(int numOfSugarTeaspoon)
        {
            return $" {numOfSugarTeaspoon} teaspoon sugar added.";
        }
        public virtual string AddCoffee(int numOfCoffeeTeaspoon)
        {
            return $" {numOfCoffeeTeaspoon} teaspoon coffee added.";
        }
        public virtual string AddCocoa(int numOfCocoaTeaspoon)
        {
            return $" {numOfCocoaTeaspoon} teaspoon cocoa added.";
        }
        public virtual string AddTeaExtract()
        {
            return $"TeaExtract added.";
        }
        public virtual string PourHotWater()
        {
            return $"Hot water poured";
        }
        public virtual string PourMilk()
        {
            return $"Milk poured";
        }
    }
}
