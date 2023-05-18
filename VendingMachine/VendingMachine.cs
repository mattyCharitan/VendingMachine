﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.FactoryMethod;
using VendingMachine.Observer;
using VendingMachine.State;

namespace VendingMachine
{
    public class VendingMachine
    {
        public Dictionary<Product, int> inventory {  get; set; }
        private ReportFactory dailyReport; //only initialized in the end of the day
        private StateClass currentState;
        private QuantityObserver quantityObserver;


        public VendingMachine()
        {

            inventory = new Dictionary<Product, int>();
            currentState = new ChoosingState(new Purchase());
            quantityObserver = new QuantityObserver();

        }

        public void DecreaseQuantity(Product product)
        {
            if (inventory.ContainsKey(product))
            {
                int currentQuantity = inventory[product];
                inventory[product] = currentQuantity - 1;

                if (currentQuantity < 5)
                {
                    quantityObserver.notifyLowQuantity(product);
                }
            }
        }
    }
}
