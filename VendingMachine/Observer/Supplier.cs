using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Observer
{
    public class Supplier
    {
        private VendingMachineClass vendingMachine;
        public Supplier(VendingMachineClass vendingMachine) {
            this.vendingMachine = vendingMachine;
        }
        public void AddQuantity( Product product, int amount)
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
