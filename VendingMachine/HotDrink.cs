using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class HotDrink : Drink {
        HotDrinkBuilder hotDrinkBuilder;
        public HotDrink(HotDrinkBuilder hotDrinkBuilder,Drink drink)
        {
            this.hotDrinkBuilder = hotDrinkBuilder; 
            this.Name=drink.Name;
            this.Price=drink.Price;
        }
    }
}


