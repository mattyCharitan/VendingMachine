using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Decorator
{
    public class BagDecorator : ProductDecorator
    {
        public BagDecorator(Product product) : base(product)
        {
        }
        public override decimal GetCost()
        {
            return base.GetCost() + 2;
        }
        public override string Wrapper()
        {
            return "this is wrapped with a bag.";
        }
    }
}
