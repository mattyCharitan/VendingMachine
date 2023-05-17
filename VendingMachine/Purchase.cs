using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.StateState;

namespace VendingMachine
{
    public class Purchase
    {
        
        private State state;
        public Purchase(State state)
        {
            this.state = new SelectionState(this);
        }
        public void ChangeState(State state)
        {
            this.state = state;
        }
    }
}
