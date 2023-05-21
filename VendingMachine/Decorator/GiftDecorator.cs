using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Decorator
{
    public class GiftDecorator : ProductDecorator
    {
        public GiftDecorator(Product product) : base(product)
        {
            this.Name = product.Name;
            this.Price = GetCost();
        }
        public override decimal GetCost()
        {
            return base.GetCost()+10;
        }
        public override string Wrapper()
        {
            return "this is wrapped with gift packaging.";
        }
    }
}
