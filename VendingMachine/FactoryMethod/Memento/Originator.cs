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
        private StateClass state;

        public Originator() { }

        public Memento Save()
        {
            return new Memento(state);
        }

        public void Restore(Memento memento)
        {
            this.state = memento.GetState();
        }
    }
}
