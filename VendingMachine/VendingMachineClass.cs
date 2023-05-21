using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.FactoryMethod;
using VendingMachine.FactoryMethod.Memento;
using VendingMachine.Observer;
using VendingMachine.State;

namespace VendingMachine
{
    public class VendingMachineClass
    {
        public Dictionary<Product, int> inventory {  get; set; }
        public Originator originator;
        public CareTaker careTaker;
        private ReportFactory dailyReport; //only initialized in the end of the day
        private QuantityObserver quantityObserver;
        public Supplier supplier;
        public Purchase purchase;
        public bool paid { get; set; }  


        public VendingMachineClass()
        {

            inventory = new Dictionary<Product, int>();
            purchase = new Purchase();
            purchase.SetState(new ChoosingState(purchase));
            supplier = new Supplier(this);
            quantityObserver = new QuantityObserver(supplier); //fix the new
            paid = false;
            careTaker= new CareTaker();
            originator = new Originator(careTaker);

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
