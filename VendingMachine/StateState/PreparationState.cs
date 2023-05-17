using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.StateState
{
    public class PreparationState : State
    {
        public PreparationState(Purchase purchase) : base(purchase)
        {
        }
        public override void Selection()
        {
            //can't select anymore
        }
        public override void Exit()
        {
            //you can do this ? does exit mean cancel?
        }

        public override void Package()
        {
            //you can do this
        }

        public override void Payment()
        {
            //user paid already,so do nothing.
        }


    }
}
