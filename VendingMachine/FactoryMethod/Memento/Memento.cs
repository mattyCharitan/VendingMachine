using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.State;

namespace VendingMachine.FactoryMethod.Memento
{
    public class Memento
    {
        private StateClass state;

        public Memento(StateClass state)
        {
            this.state = state;
        }

        public StateClass GetState()
        {
            return state;
        }
    }

}
