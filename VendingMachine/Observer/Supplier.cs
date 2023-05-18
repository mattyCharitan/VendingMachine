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
            // Check if the vending machine has the specified product in the inventory
            if (vendingMachine.inventory.ContainsKey(product))
            {
                // Increment the quantity of the product
                vendingMachine.Inventory[product] += amount;
            }
            else
            {
                // Add the product to the inventory with the specified quantity
                vendingMachine.Inventory.Add(product, amount);
            }
        }
    }
}
