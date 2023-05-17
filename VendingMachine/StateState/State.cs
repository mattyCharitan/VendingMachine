using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.StateState
{
    public abstract class State
    {
        protected Purchase purchase;

        public State(Purchase purchase)
        {
            this.purchase = purchase;
        }

        public abstract void Selection();
        public abstract void Package();
        public abstract void Payment();
        public abstract void Exit();

    }
}
