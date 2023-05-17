
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.State
{
    public class ChoosingState : StateClass
    {
        private readonly Purchase _context;

        public ChoosingState(Purchase context)
        {
            _context = context;
        }
        public override void choose()
        {
            Console.WriteLine("Choose an item.");
        }

        public override void cancel()
        {
            _context.SetState(new CancelState(_context));
        }

        public override void package()
        {
            throw new InvalidOperationException("Cannot package in Choosing state.");
        }

        public override void pay()
        {
            throw new InvalidOperationException("Cannot pay in Choosing state.");
        }
    }
}
