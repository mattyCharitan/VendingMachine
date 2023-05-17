using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.State
{
    public class CancelState: StateClass
    {
        private readonly Context _context;

        public CancelState(Context context)
        {
            _context = context;
        }

        public override void cancel()
        {
            Console.WriteLine("Cancel the payment.");
        }
    

        public override void choose()
        {
            throw new InvalidOperationException("Cannot choose in cancel state.");
        }

        public override void package()
        {
            throw new InvalidOperationException("Cannot package in cancel state.");
        }

        public override void pay()
        {
            throw new InvalidOperationException("Cannot pay in cancel state.");
        }
    }
}
