using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.State;

namespace VendingMachine.FactoryMethod.Memento
{
    public class MementoClass
    {
        //prodcut
        DateTime dt;
        Product p;
        decimal amount;
        decimal change;

        public MementoClass(Product p, decimal amount)
        {
            dt = DateTime.Now;
            this.p = p;
            this.amount = amount;
            change = amount - p.Price;
        }

        public override string ToString()
        {
            return $"DateTime: {dt} Product: {p.Name}, {p.Price} amount entered: {amount} change given: {change}";
        }


    }

}
