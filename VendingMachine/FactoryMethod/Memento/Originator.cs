using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.State;

namespace VendingMachine.FactoryMethod.Memento
{
    public class Originator
    {
        Product product;
        decimal amountEnterd;
        MementoClass memento;
        private CareTaker taker;

        public Originator(CareTaker taker)
        {
            this.taker = taker;
        }

        public void addProduct(Product product)
        {
            this.product = product;
        }

        public void addAmount(decimal amount)
        {
            this.amountEnterd = amount;
        }

        public void CreateMemnto() 
        {
           memento = new MementoClass(this.product, this.amountEnterd);
           taker.AddMemento(memento);
        }

    }
}
