using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.StateState
{
    public class PayingState : State
    {
        public PayingState(Purchase purchase) : base(purchase)
        {
        }
        public override void Selection()
        {
            // Disabled, so do nothing.
        }
        public override void Exit()
        {
            //you can do this ?
        }

        public override void Package()
        {
            // Disabled, so do nothing.
        }

        public override void Payment()
        {
            //you can do this
        }

        
    }
}
