using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.State
{
    public abstract class StateClass
    {
        public abstract void choose();
        public abstract void package();
        public abstract void pay();
        public abstract void cancel();
        public  string GetStateName()
        {
            return this.GetType().Name;
        }
    }
}
