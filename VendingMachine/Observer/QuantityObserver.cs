using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Observer
{
    public class QuantityObserver
    {
        private Supplier supplier;

        public QuantityObserver(Supplier supplier)
        {
            this.supplier = supplier;
        }

        public void NotifyLowQuantity(Product product, VendingMachine vendingMachine)
        {
            Console.WriteLine($"Low quantity alert: {product.productName}");
            supplier.AddQuantity(vendingMachine, product, 10); //hard coded amount
        }
    }
}
