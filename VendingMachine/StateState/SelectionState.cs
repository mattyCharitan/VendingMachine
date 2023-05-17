using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.StateState
{
    public class SelectionState : State
    {
        public SelectionState(Purchase purchase) : base(purchase)
        {
        }

        public override void Selection()
        {
            //you can do this
        }

        public override void Exit()
        {
            //you can do this
        }

        public override void Package()
        {
           
        }

        public override void Payment()
        {
           
        }

       
    }
}
