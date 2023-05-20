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

        public StateClass state { get; }

        public MementoClass(StateClass state)
        {
            this.state = state;
        }

       
    }

}
