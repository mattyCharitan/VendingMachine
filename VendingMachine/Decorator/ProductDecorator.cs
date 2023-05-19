using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Decorator
{
    public abstract class ProductDecorator:Product
    {
        protected Product product;
        public ProductDecorator(Product product)
        {
            this.product = product;
        }
        //public abstract float GetCost();
        public override decimal GetCost()
        {
            return product.Price;
        }
        public abstract string Wrapper();

    }
}
