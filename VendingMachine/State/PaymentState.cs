namespace VendingMachine.State
{
    internal class PaymentState : StateClass
    {
        private readonly Purchase _context;

        public PaymentState(Purchase context)
        {
            _context = context;
        }
        public override void choose()
        {
            throw new InvalidOperationException("Cannot choose in Payment state.");
        }

        public override void package()
        {
            throw new InvalidOperationException("Cannot package in Payment state.");
        }

        public override void pay()
        {
            Console.WriteLine("Process the payment.");
        }

        public override void cancel()
        {
            _context.SetState(new CancelState(_context));
        }

        
    }
}