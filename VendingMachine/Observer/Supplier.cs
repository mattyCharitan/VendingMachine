using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Observer
{
    public class Supplier
    {
        public void AddQuantity(VendingMachine vendingMachine, Product product, int amount)
        {
            if (vendingMachine.inventory.ContainsKey(product))
            {
                vendingMachine.inventory[product] += amount;
            }
            else
            {
                vendingMachine.inventory.Add(product, amount);
            }
        }
    }
}
