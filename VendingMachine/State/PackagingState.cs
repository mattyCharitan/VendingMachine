using System;


namespace VendingMachine.State
{
    public class PackagingState : StateClass
    {
        private readonly Purchase _context;

        public PackagingState(Purchase context)
        {
            _context = context;
        }
        public override void choose()
        {
            _context.SetState(new ChoosingState(_context));
        }

        public override void package()
        {
            Console.WriteLine("Package the selected item.");
        }

        public override void pay()
        {
            _context.SetState(new PaymentState(_context));
        }

        public override void cancel()
        {
            _context.SetState(new CancelState(_context));
        }
    }

}
