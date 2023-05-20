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
    public class VendingMachineClass
    {
        public Dictionary<Product, int> inventory {  get; set; }
        private ReportFactory dailyReport; //only initialized in the end of the day
        public StateClass currentState;
        private QuantityObserver quantityObserver;
        public Supplier supplier;
        public Purchase purchase;
        public bool paid { get; set; }  


        public VendingMachineClass()
        {

            inventory = new Dictionary<Product, int>();
            purchase = new Purchase();
            currentState = new ChoosingState(purchase); //fix the new
            supplier = new Supplier(this);
            quantityObserver = new QuantityObserver(supplier); //fix the new
            paid = false;

        }

        public void DecreaseQuantity(Product product)
        {
            if (inventory.ContainsKey(product))
            {
                int currentQuantity = inventory[product];
                inventory[product] = currentQuantity - 1;

                if (currentQuantity < 5)
                {
                    quantityObserver.NotifyLowQuantity(product, this);
                }
            }
        }

        public Product SearchProductByName(string productName)
        {
            foreach (var product in inventory.Keys)
            {
                if (product.Name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }

            return null; // Product not found
        }

    }
}
